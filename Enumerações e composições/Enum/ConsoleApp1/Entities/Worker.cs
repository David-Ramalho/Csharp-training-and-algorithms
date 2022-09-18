using System;
using ConsoleApp1.Entities.Enums;
using System.Collections.Generic;


namespace ConsoleApp1.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } //Composition

        //Composition list type. Workers may have many contracts so we'll be using lists.
        public List<HourContract> Contracts { get; set; }= new List<HourContract>();

        public Worker()
        {
            //Basic constructor
        }
    }
}

