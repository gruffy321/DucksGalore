using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DucksGalore.Ducks
{
    public class FlyWithWings : FlyBehaviour
    {
        void FlyBehaviour.Fly()
        {
            Debug.WriteLine("this object has naturally grown wings and can fly accordingly");
        }
    }
}
