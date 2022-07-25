using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DucksGalore.Ducks
{
    public class FlyJetPack : FlyBehaviour
    {
        void FlyBehaviour.Fly()
        {
            Debug.WriteLine("This object has been assigned an advanced jetpack.\nIt can reach speeds of up to Mach3 now!");
        }
    }
}
