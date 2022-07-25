using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DucksGalore.Ducks
{
    public class FlyNoWings : FlyBehaviour
    {
        void FlyBehaviour.Fly()
        {
            Debug.WriteLine("This object was not assigned an airborne behaviour and thusly; Cannot Fly");
        }
    }
}
