using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_For02
{
    /// <summary>
    /// 星形三角形
    ///    *
    ///   ***
    ///	 *****
    /// *******
    ///*********
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int k = 1; k <= 10; k += 2)
            {
                int countE = (10 - k) / 2;
                int countstar2 = k;

                string row = new string(' ', countE) + new string('*', countstar2) + new string(' ', countE);
                Console.WriteLine(row);
            }

        }
    }
}

