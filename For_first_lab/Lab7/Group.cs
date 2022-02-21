using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name;
        public static int counter=0;
        public Student[] students;
        public Group()
        {
            counter++;
            Id = counter;
        }
    }
}
