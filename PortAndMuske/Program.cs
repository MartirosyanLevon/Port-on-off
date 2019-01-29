using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PortAndMuske
{
    class Program
    {
        static void Main(string[] args)
        {

            // Port on  |

            byte port = 0xf0;   // 240       // 1111 0000
            byte musk = 0x02;   // 02;       // 0000 0010
            Console.WriteLine("port = {0:x} 1111 0000", port);      // 1111 0000
            Console.WriteLine("\nmusk = {0:x} 0000 0010", musk);

            port = (byte)(port | musk);                  // 1111 0000
                                                         // 0000 0010
                                                         // 1111 0010

            Console.WriteLine("\nport = {0:x} 1111 0000 \n          0000 0010  \n          1111 0010", port);     // 1111 0010    //0xf2    //   242  


            // Port off &


            byte muske = 0xfd;    //  253             // 1111 1101
            Console.WriteLine("\nMuske = {0:x} 1111 1101", muske);

            port = (byte)(port & muske);              // 1111 0010
                                                      // 1111 1101
                                                      // 1111 0000

            Console.WriteLine("\nport = {0:x} 1111 0010 \n          1111 1101       \n          1111 0000 ",port);  // 1111 0000    //240    //0xf0


            Console.ReadKey();
        }
    }
}
