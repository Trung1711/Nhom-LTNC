using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_1
{
    class Program
    {

        static void Main(string[] args)
        {
            UserInformation c = new UserInformation();
            c.GetUserInformation();
            c.PrintInformation();
            Console.ReadLine();
        }
    }
}
