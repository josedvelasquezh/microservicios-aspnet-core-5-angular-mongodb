﻿using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Servicios.API.Libreria.Core.Entities;

namespace Servicios.API.Libreria.Core.ContextMongoDB
{
    public class AutorContext : IAutorContext
    {
        private readonly IMongoDatabase _db;

        public AutorContext(IOptions<MongoSettings> options)
        {
            MongoClient client = new MongoClient(options.Value.ConnectionString);

            _db = client.GetDatabase(options.Value.Database);
        }

        public IMongoCollection<Autor> Autores => _db.GetCollection<Autor>("autor");
    }
}
