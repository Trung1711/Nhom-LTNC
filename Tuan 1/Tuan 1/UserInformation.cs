 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan_1
{
    class UserInformation
    {
        public string userName;
        public int userAge;
        public uint userID;
        
        public  void GetUserInformation()
        {
            Console.WriteLine("Please type your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Please type your age: ");
            userAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please type your ID: ");
            userID = Convert.ToUInt32(Console.ReadLine());


        }
        public void PrintInformation()
        {
            Console.WriteLine("Youre name is {0} ", userName);
            Console.WriteLine("Youre age is {0}", userAge);
            Console.WriteLine("Your Id is {0}", userID);
        }
        
    }
}
