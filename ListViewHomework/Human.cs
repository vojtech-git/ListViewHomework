using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListViewHomework
{
    public class Human
    {
        public static List<Human> Humans = new List<Human>();

        public string Name { get; set; }
        public string LastName { get; set; }
        public int BirthYear { get; set; }
        public int BirthNumber { get; set; }
        public string FullName { get; set; }

        public Human(string _name, string _lastName, int _birthYear, int _birthNumber)
        {
            Name = _name;
            LastName = _lastName;
            BirthYear = _birthYear;
            BirthNumber = _birthNumber;
            FullName = _name + " " + _lastName;
        }

        //public override string ToString()
        //{
        //    return this.FullName;
        //}
    }
}
