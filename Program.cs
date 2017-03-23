using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Person paul = new Person("Paul", 70.4, 21);
            Person baby = new Person("Rachel", 2.5);

            paul.FirstName = "Lauren";
            // changes the name using the properties get and set methods.

            Console.WriteLine(paul.IntroduceYourself());

            paul.CelebrateBirthday();
            //we call the function CelebrateBirthday
            Console.WriteLine(paul.IntroduceYourself());
            //we then call the function into the command WriteLine

            paul.ChangeNameByDeedPoll("George");
            Console.WriteLine(paul.IntroduceYourself());
            // changes the name using the ChangeNameByDeedPoll function

            Console.ReadKey();
        }
    }
}
