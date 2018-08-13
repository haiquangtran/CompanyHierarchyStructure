using MomentonCodingChallenge.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentonCodingChallenge.Models
{
    public class Manager : IWorker
    {
        public List<IWorker> Subordinates { get; set; }
        public string Name { get; set; }
        public int WorkerID { get; set; }
        public WorkerType WorkerType { get; set; }

        public Manager(string name, int employeeID, WorkerType workerType)
        {
            Subordinates = new List<IWorker>();
            Name = name;
            WorkerID = employeeID;
            WorkerType = workerType;
        }

        public void Add(IWorker worker)
        {
            Subordinates.Add(worker);
        }

        public void Remove(IWorker worker)
        {
            Subordinates.Remove(worker);
        }
    }
}
