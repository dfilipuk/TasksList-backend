using System.Threading.Tasks;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using WebApiDemo.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace WebApiDemo.Repository
{
    public class MyTaskRepository
    {
        private readonly string TASK_COLLECTION_NAME;
        private IMongoDatabase database;

        public MyTaskRepository(IConfiguration appConfiguration)
        {
            string connectionUrl = appConfiguration.GetConnectionString("MongoConnection");
            var connection = new MongoUrlBuilder(connectionUrl);
            var client = new MongoClient(connectionUrl);
            database = client.GetDatabase(connection.DatabaseName);
            TASK_COLLECTION_NAME = appConfiguration.GetSection("MongoCollection")["MyTask"];
        }

        public async Task<List<MyTask>> FindAll()
        {
            var filter = new BsonDocument();
            var collection = database.GetCollection<MyTask>(TASK_COLLECTION_NAME);
            return await collection.Find(filter).ToListAsync();
        }
    }
}