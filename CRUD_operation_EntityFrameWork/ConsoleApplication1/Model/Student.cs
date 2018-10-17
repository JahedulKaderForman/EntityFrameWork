using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Model
{
    class Student
    {
        public Student(string name,string regNo,string address)
        {
            this.Name = name;
            this.RegNo = regNo;
            this.Address = address;
        }

        public Student()
        {
            
        }
        public int  Id { get; set; }

        public string Name { get; set; }

        public string RegNo { get; set; }

        public string Address { get; set; }
    }
}
