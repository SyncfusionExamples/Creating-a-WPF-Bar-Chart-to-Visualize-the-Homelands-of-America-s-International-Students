using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternationalStudents
{
    public class StudentsData
    {
        public ObservableCollection<StudentsModel> Data { get; set; }
        public StudentsData() 
        {
            Data = new ObservableCollection<StudentsModel>()
            {
                new StudentsModel("Japan",16054 ),
                new StudentsModel("Nigeria",17640),
                new StudentsModel("Taiwan",21834),
                new StudentsModel("Vietnam",21900),
                new StudentsModel("Canada",27876),
                new StudentsModel("South Korea",43847),
                new StudentsModel("India",268923),
                new StudentsModel("China",289526),
            };
        }
    }
}