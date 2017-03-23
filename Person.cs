using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    class Person
    {
        string firstName = "Lauren";
        double weight;
        int age;
        //here we decalire variables that are shared by the two constructors and the properties

        /* start properties */
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        //this the declaration of a property. Essentially it is a function but it is identified by get; set;
        //It is more ideal than simply declaring variables as it allows us to add extra functionality. 
        //It does require the variable to be declared first, and notice the caps ON F to diferentiate it

        public double Weight
        {
            get { return this.weight; }
           // set { this.weight = value; } no set method would mean it cannot be changed
        }
        //this is a another property. Note the CAPS on Weight to declare the property, and its USE of lowercase weight the variable
        /* end properties */

        /* start constructors */
        public Person(string firstName, double weight, int age)
        {
            this.firstName = firstName;
            //use of this 
            this.weight = weight;
            this.age = age;
        }
        //this is a constructor, we can create two constructors with the same name (Person) so long as they have differing inputs.
        //here we see Person with three input and another Person with two inputs.
        //see Program file to see the two ways of creating the Person object, but the second Person, baby, could not exist if we did not have a second constructor which just two inputs

        public Person(string firstName, double weight)
        {
            this.firstName = firstName;
            this.weight = weight;
        }
        //this is the second constructor, with just two user inputs
        /* end constructors */

        /* start functions */
        public void CelebrateBirthday()
        {
            this.age++;
        }
        //this is a function. when we call it in the program, it adds one to the int 'age'. See use of void for the distinction of a function

        public void ChangeNameByDeedPoll(string newName)
        {
            this.firstName = newName;
        }
        //this is a second function, which takes an input, that will re assign the Person.firstName to the newName input

        public string IntroduceYourself()
        {
            return "Hello, my name is " 
                    + this.firstName
                    + " and I am " 
                    + this.age 
                    + " years old.";
        }
        //this is a third function that will present the information back to the screen. 
        //See the use of string for the distinction of a function
    }
}
