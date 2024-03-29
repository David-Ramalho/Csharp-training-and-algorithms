﻿using System;
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
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {
            //Basic constructor
        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        public void RemoveContract(HourContract contract)
        {
            Contracts.Remove(contract);
        }

        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach(HourContract contract in Contracts)
            {
                if(contract.Date.Year== year && contract.Date.Month== month)
                {
                    sum += contract.TotalValue();
                }
                }
            return sum;
            }

        public override string ToString()
        {
            return "\nName: " + Name 
                +                
                "\nDepartment: " + Department.Name
                +
                "\nbase wage: " + BaseSalary
                +                
                "\nLevel: " + Level
                ;
        }
    }

    }


