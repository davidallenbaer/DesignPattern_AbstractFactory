using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_AbstractFactory
{
    public class Dog : IAnimal
    {
        public string speak()
        {
            return "Bark bark";
        }
    }
}