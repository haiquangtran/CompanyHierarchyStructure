using MomentonCodingChallenge.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentonCodingChallenge.Models
{
    public class Employee : IWorker
    {
        public string Name { get; set; }
        public int WorkerID { get; set; }
        public WorkerType WorkerType { get; set; }

        public Employee(string name, int employeeID, WorkerType workerType)
        {
            Name = name;
            WorkerID = employeeID;
            WorkerType = workerType;
        }
    }
}
