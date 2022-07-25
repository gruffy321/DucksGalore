using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DucksGalore.Ducks
{
    public class FunkyDuck : Duck
    {
        public FunkyDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
            DisplaySpecies("I AM FUNKYDUCK");
            PerformQuack();
            PerformFly();
            SwapWingsForJetPack();

        }
    }
}
