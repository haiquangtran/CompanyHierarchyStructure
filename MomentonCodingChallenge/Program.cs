using MomentonCodingChallenge.Models;
using MomentonCodingChallenge.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentonCodingChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            var companyRepository = new CompanyRepository();
            Company company = new Company(companyRepository);
            company.PrintHierarchy();

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
        }
    }
}
