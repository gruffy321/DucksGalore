using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DucksGalore.Ducks
{
    public abstract class Duck
    {
        public string Name { get; set; }
        bool swap = false;
        protected QuackBehaviour? quackBehaviour;
        protected FlyBehaviour? flyBehaviour;
        public void PerformQuack()
        {
            quackBehaviour?.Quack();
        }
        public void PerformFly()
        {
            flyBehaviour?.Fly();
        }
        public virtual void DisplaySpecies(string? species)
        {
            if (species == null)
                species = "NON SPECIFIED";
            Debug.WriteLine($"{species} was declared as this species classification"); 
        }
        public void SwapWingsForJetPack()
        {
            Debug.WriteLine($"swap variable = {swap}");
            swap = !swap;
            Debug.WriteLine($"swap variable changed to {swap}");
            if (swap)
            {
                flyBehaviour = new FlyJetPack();
            }
            else
            {
                flyBehaviour = new FlyWithWings();
            }
            flyBehaviour.Fly();
        }
        public void ChangeFlyBehaviour(FlyBehaviour fb)
        {
            flyBehaviour = fb;
        }
        public void ChangeQuackBehaviour(QuackBehaviour qb)
        {
            quackBehaviour = qb;
        }
    }
}
