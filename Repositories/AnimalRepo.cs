﻿using System.Collections.Generic;
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
    public interface IAnimalRepo
    {
        Animal GetById(int id);
    }

    public class AnimalRepo : IAnimalRepo
    {
        private readonly ZooManagementDbContext _context;

        public AnimalRepo(ZooManagementDbContext context)
        {
            _context = context;
        }

        public Animal GetById(int id)
        {
            return _context.Animal
            .Single(animal => animal.Id == id);
        }
    }
}
