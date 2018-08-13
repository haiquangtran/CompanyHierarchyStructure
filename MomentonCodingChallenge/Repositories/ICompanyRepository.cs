using MomentonCodingChallenge.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MomentonCodingChallenge.Repositories
{
    public interface ICompanyRepository
    {
        IWorker GetHeadWorker();
    }
}
