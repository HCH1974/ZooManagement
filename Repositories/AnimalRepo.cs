﻿using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using ZooManagement.Models.Request;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System;
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
            return _context.Animal
                .Where(p => search.SpeciesId == null || p.SpeciesId == search.SpeciesId)
                .Skip((search.Page - 1) * search.PageSize)
                .Take(search.PageSize);
        }

        public int Count(AnimalSearchRequest search)
        {
            return _context.Animal
                .Count(p => search.SpeciesId == null || p.SpeciesId == search.SpeciesId);
        }

        public void CreateAnimal(AnimalRequest animalRequest)
        {
            Animal newAnimal = new Animal
            {
                SpeciesId = animalRequest.SpeciesId,
                Name = animalRequest.Name,
                Sex = animalRequest.Sex,
                DateOfBirth = animalRequest.DateOfBirth,
                DateAcquired = animalRequest.DateAcquired,
            };
            _context.Animal.Add(newAnimal);
            _context.SaveChanges();
        }
    }
}


