using MomentonCodingChallenge.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentonCodingChallenge.Models
{
    public interface IWorker
    {
        int WorkerID { get; set; }
        string Name { get; set; }
        WorkerType WorkerType { get; set; }
    }
}
