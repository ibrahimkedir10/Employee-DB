using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDBApp
{
    public class Department
    {
        public  int ID { get; set; }
        public string DepartmentTitle { get; set; }
        public int EmployeeCount { get; set; }
        public string ImgURL { get; set; }
        public string DepartmentDiscription { get; set; }
    }
}
