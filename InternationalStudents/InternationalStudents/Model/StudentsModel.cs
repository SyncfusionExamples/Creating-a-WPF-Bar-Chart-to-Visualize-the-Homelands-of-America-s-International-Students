using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalStudents
{
    public class StudentsModel
    {
        public string Country { get; set; }
        public double Count { get; set; }

        public StudentsModel(string country,  double count)
        {
            Country = country;
            Count = count;
        }
    }
}