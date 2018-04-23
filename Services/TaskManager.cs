using System;
using System.Collections.Generic;
using MongoDB.Driver;
using WebApiDemo.Models;
using WebApiDemo.Repository;

namespace WebApiDemo.Services
{
    public class TaskManager
    {
        private MyTaskRepository repository;

        public TaskManager(MyTaskRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<MyTask> GetAllTasks()
        {
            return repository.FindAll().GetAwaiter().GetResult();
        }
    }
}