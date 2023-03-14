using System.Collections.Generic;
using System.Linq;
using ZooManagement.Models.Database;
using Microsoft.AspNetCore.Cryptography.KeyDerivation;
using System.Security.Cryptography;
using System;
using Microsoft.AspNetCore.Http;
using System.Web;
using System.Text;

namespace ZooManagement.Repositories
{
    public interface ISpeciesRepo
    {
        List<string> GetAllSpecies();
    }

    public class SpeciesRepo : ISpeciesRepo
    {
        private readonly ZooManagementDbContext _context;

        public SpeciesRepo(ZooManagementDbContext context)
        {
            _context = context;
        }
        public List<string> GetAllSpecies()
        {
            var speciesList = new List<string>();
            foreach (var species in _context.Species)
            {
                if (!speciesList.Contains(species.SpeciesName))
                {
                    speciesList.Add(species.SpeciesName);
                }
            }
            return speciesList;
        }
    }
}

