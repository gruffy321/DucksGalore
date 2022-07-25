using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DucksGalore.Ducks
{
    public class Quack : QuackBehaviour
    {
        void QuackBehaviour.Quack()
        {
            Debug.WriteLine("this object just quacked with the tone of it's species");
        }
    }
}
