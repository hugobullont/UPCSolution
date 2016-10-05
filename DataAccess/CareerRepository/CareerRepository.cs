using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.CareerRepository
{
    public class CareerRepository : ICareerRepository
    {
        public List<Entities.Career> GetAllCareers()
        {
           EFUPCConnectionString UPCModel = new EFUPCConnectionString();
           List<Career> careers = (from c in UPCModel.Careers select c).ToList();
           return careers;
        }
    }
}
