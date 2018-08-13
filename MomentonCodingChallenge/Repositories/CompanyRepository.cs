using MomentonCodingChallenge.Common;
using MomentonCodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentonCodingChallenge.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private IWorker _headWorker;

        public CompanyRepository()
        {
            GenerateEmployees();
        }

        public IWorker GetHeadWorker()
        {
            return _headWorker;
        }

        // Note: Hard-coded values but ideally data would be retrieved from database or API
        public void GenerateEmployees()
        {
            var ceo = new Manager("Jamie", 150, WorkerType.EMPLOYEE);
            
            var manager1 = new Manager("Alan", 100, WorkerType.EMPLOYEE);
            var manager2 = new Manager("Steve", 400, WorkerType.CONTRACTOR);

            var worker1 = new Employee("Martin", 220, WorkerType.EMPLOYEE);
            var worker2 = new Employee("Alex", 275, WorkerType.EMPLOYEE);
            var worker3 = new Employee("David", 190, WorkerType.CONTRACTOR);

            ceo.Add(manager1);
            ceo.Add(manager2);
            
            manager1.Add(worker1);
            manager1.Add(worker2);

            manager2.Add(worker3);

            _headWorker = ceo;
        }
    }

}
