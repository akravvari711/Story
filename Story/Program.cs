using Story.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story
{
    class Program
    {
        static void Main(string[] args)
        {
            Human member1 = new Human();
            member1.John();
            Console.WriteLine(member1);


            Human member2 = new Human();
            member2.Anna();
            Console.WriteLine(member2);
        }
    }
}
