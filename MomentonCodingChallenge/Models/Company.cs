using MomentonCodingChallenge.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentonCodingChallenge.Models
{
    public class Company
    {
        private ICompanyRepository _companyRepository;

        public Company(ICompanyRepository companyRepository)
        {
            _companyRepository = companyRepository;
        }
        
        /// <summary>
        /// Prints the companies hierarchy of the workers
        /// <param name="employee"></param>
        /// <param name="prefix"></param>
        public void PrintHierarchy()
        {
            var ceo = _companyRepository.GetHeadWorker();
            Print(ceo, string.Empty);
        }
        
        /// <summary>
        /// Recursively prints the worker hierachy of the company in the following format:
        /// i.e CEO
        ///        Manager
        ///                Employee
        ///                Employee
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="prefix"></param>
        private void Print(IWorker worker, string prefix)
        {
            Console.WriteLine($"{prefix}{worker.Name}");
            prefix += "\t";

            if (worker is Employee)
                return;

            var subordinates = ((Manager)worker).Subordinates;
            foreach (IWorker subordinate in subordinates)
            {
                Print(subordinate, prefix);
            }
        }
    }
}
