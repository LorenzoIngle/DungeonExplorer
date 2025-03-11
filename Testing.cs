using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DungeonExplorer
{
    ///<summary>
    ///This class allows for testing wether things are true
    ///or false during developement using Debug.Assert
    ///</summary>
    static class Testing
    {
        public static void TestHealth(int Health)
        {
            Debug.Assert(0 <= Health && Health <= 100,
                "health must be between 0 and 100 " +
                "inclusive otherwise game logic breaks");
        }
    }
}
