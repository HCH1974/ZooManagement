using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Models.Request;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using System.Web;
using System.Text;
using NLog;

namespace ZooManagement.Repositories
{
    public interface IAnimalRepo
    {
        Animal GetById(int id);
        IEnumerable<Animal> Search(AnimalSearchRequest search);
        int Count(AnimalSearchRequest search);
        void CreateAnimal(AnimalRequest animalRequest);

    }

    public class AnimalRepo : IAnimalRepo
    {
        private readonly ZooManagementDbContext _context;
        private static readonly NLog.ILogger Logger = LogManager.GetCurrentClassLogger();
        public AnimalRepo(ZooManagementDbContext context)
        {
            _context = context;
        }

        public Animal GetById(int id)
        {
            var retrievedAnimal = new Animal();
            try
            {
                retrievedAnimal = _context.Animal.Single(animal => animal.Id == id);
            }
            catch (System.Exception)
            {
                Logger.Info($"Animal with id {id} not found.");
                throw new ArgumentException($"Animal with id {id} not found.");
            }
            return retrievedAnimal;
        }
        public IEnumerable<Animal> Search(AnimalSearchRequest search)
        {
            var searchSpecies = new Species();
            IQueryable<Species> searchSpeciesList;
            var searchSpeciesIdList = new List<int>();
            Console.WriteLine($"search.SpeciesName is {search.SpeciesName}");
            if (search.SpeciesName != null)
            {
                try
                {
                    searchSpecies = _context.Species.Single(species => species.SpeciesName == search.SpeciesName);
                }
                catch (System.Exception)
                {
                    throw new ArgumentException($"Invalid Species Name."); ;
                }
            }
            if (search.Classification != "")
            {
                try
                {
                    searchSpeciesList = _context.Species
                                            .Where(species => species.Classification == search.Classification);
                }
                catch (System.Exception)
                {
                    throw new ArgumentException($"Invalid Classification."); ;
                }
                foreach (Species species in searchSpeciesList)
                {
                    searchSpeciesIdList.Add(species.Id);
                }
            }
            return _context.Animal
                .Where(p => search.SpeciesName == null || p.SpeciesId == searchSpecies.Id)
                .Where(q => search.Classification == null || searchSpeciesIdList.Contains(q.SpeciesId))
                .Skip((search.Page - 1) * search.PageSize)
                .Take(search.PageSize);
        }

        public int Count(AnimalSearchRequest search)
        {
            var searchSpecies = new Species();
            IQueryable<Species> searchSpeciesList;
            var searchSpeciesIdList = new List<int>();
            if (search.Classification != "")
            {
                try
                {
                    searchSpeciesList = _context.Species
                                            .Where(species => species.Classification == search.Classification);
                }
                catch (System.Exception)
                {
                    throw new ArgumentException($"Invalid Classification."); ;
                }
                foreach (Species species in searchSpeciesList)
                {
                    searchSpeciesIdList.Add(species.Id);
                }
            }
            return _context.Animal
                .Where(p => search.SpeciesName == null || p.SpeciesId == searchSpecies.Id)
                .Where(q => search.Classification == null || searchSpeciesIdList.Contains(q.SpeciesId))
                .Count();
        }


        public void CreateAnimal(AnimalRequest animalRequest)
        {
            var dateOfBirth = new DateTime(0);
            var dateAcquired = new DateTime(0);
            //check valid dates
            try
            {
                dateOfBirth = DateTime.Parse(animalRequest.DateOfBirth);
            }
            catch (System.Exception)
            {
                throw new ArgumentException($"Date of Birth Invalid.");
            }
            try
            {
                dateAcquired = DateTime.Parse(animalRequest.DateAcquired);
            }
            catch (System.Exception)
            {

                throw new ArgumentException($"Date Acquired Invalid.");
            }

            Animal newAnimal = new Animal
            {
                SpeciesId = animalRequest.SpeciesId,
                Name = animalRequest.Name,
                Sex = animalRequest.Sex,
                DateOfBirth = dateOfBirth,
                DateAcquired = dateAcquired,
                EnclosureId = animalRequest.EnclosureId,
            };
            Boolean newAnimalIsOk = ValidateNewAnimal(newAnimal);
            if (newAnimalIsOk)
            {
                var selectedEnclosure = _context.Enclosure.FirstOrDefault(x => x.Id == animalRequest.EnclosureId);
                if (selectedEnclosure != null)
                {
                    selectedEnclosure!.CurrentNumberOfAnimals += 1;
                }
                _context.Animal.Add(newAnimal);
                _context.SaveChanges();
            }
        }
        public Boolean ValidateNewAnimal(Animal animal)
        {
            var species = new Species();
            var speciesToEnclosure = new SpeciesToEnclosure();
            var enclosure = new Enclosure();
            // check species exists
            try
            {
                species = _context.Species.Single(species => animal.SpeciesId == species.Id);
            }
            catch (System.Exception)
            {
                Logger.Info($"Species with id {animal.SpeciesId} not found.");
                throw new ArgumentException($"Species with id {animal.SpeciesId} not found.");
            }
            // check enclosure exists
            try
            {
                enclosure = _context.Enclosure.Single(enclosure => animal.EnclosureId == enclosure.Id);
            }
            catch (System.Exception)
            {
                Logger.Info($"Enclosure with id {animal.EnclosureId} not found.");
                throw new ArgumentException($"Enclosure with id {animal.EnclosureId} not found.");
            }
            // check space in enclosure
            if (enclosure.CurrentNumberOfAnimals == enclosure.MaximumNumberOfAnimals)
            {
                Logger.Info($"No room at the inn. Enclosure {animal.EnclosureId} is at capacity.");
                throw new ArgumentException($"No room at the inn. Enclosure {animal.EnclosureId} is at capacity.");
            }
            // check enclosure allows that species
            try
            {
                speciesToEnclosure = _context.SpeciesToEnclosure.
                Single(speciesToEnclosure => (animal.EnclosureId == speciesToEnclosure.EnclosureId && animal.SpeciesId == speciesToEnclosure.SpeciesId));
            }
            catch (System.Exception)
            {
                Logger.Info($"Species {animal.SpeciesId} not allowed in Enclosure {animal.EnclosureId}.");
                throw new ArgumentException($"Species {animal.SpeciesId} not allowed in Enclosure {animal.EnclosureId}.");
            }
            return true;
        }
    }
}


