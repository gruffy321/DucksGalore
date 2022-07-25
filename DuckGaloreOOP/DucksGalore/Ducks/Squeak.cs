using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DucksGalore.Ducks
{
    public class Squeak : QuackBehaviour
    {
        void QuackBehaviour.Quack()
        {
            Debug.WriteLine("This object just squeaked, it cant be an adult duck\n maybe it's something else altogether?!");
        }
    }
}
