using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DungeonExplorer
{
    static class Testing
    {
        public static void TestHealth(int health)
        {
            Debug.Assert(0 <= health && health <= 100, "health must be between 0 and 100 inclusive otherwise game logic breaks");
        }
    }
}
