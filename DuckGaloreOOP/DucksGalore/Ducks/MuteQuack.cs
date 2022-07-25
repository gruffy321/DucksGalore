using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;


namespace DucksGalore.Ducks
{
    public class MuteQuack : QuackBehaviour
    {
        void QuackBehaviour.Quack()
        {
            Debug.WriteLine("This object is mute and cannot vocalise");
        }
    }
}
