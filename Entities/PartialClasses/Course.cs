using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Entities
{
    public partial class Course
    {
        public string CareerName
        {
            get
            {
                //hi
                return this.Career.Name;
            }
            set
            {

            }
        }
    }
}
