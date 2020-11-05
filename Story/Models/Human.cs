using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story.Models
{
    class Human
    {
        private string _name;

        public string Name
        {
            get { return (this._name);}
            set { this._name = value; }
        }

        public Human()
        {

        }

        public void John()
        {
            Console.WriteLine("John has a house.");
        }

        public void Anna()
        {
            Console.WriteLine("Hi John.");
        }



    }
}
