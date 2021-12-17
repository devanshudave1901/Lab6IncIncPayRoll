
    //Name : Devanshu Dave
    //Student ID: 100785733
    //Date: 04 - 12 - 2021
    //Description: This is the WorkerContext page which contains the description of relationships
    //              to the model.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab6IncIncPayRoll.Models;
using Microsoft.EntityFrameworkCore;

namespace Lab6IncIncPayRoll.Contexts
{

    public class WorkerContext : DbContext
    {
        /// <summary>
        /// This is a workerContext constructor with used base options
        /// </summary>
        /// <param name="options"></param>
        public WorkerContext(DbContextOptions<WorkerContext> options) : base(options)
        {

        }
        /// <summary>
        /// Declaring or describing PieceworkWorkers as a entity
        /// </summary>
        public DbSet<PieceworkWorkerModel> Workers { get; set; }
    }
}
