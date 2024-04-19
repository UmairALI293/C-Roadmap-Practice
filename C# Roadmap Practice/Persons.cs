
namespace C__Roadmap_Practice
{
    //  Class

    public class Genders
    {
        protected string gen { get; set; }
    }
    public class PersonClass : Genders
    {
        static int a;

        public int age;

        // Property
        
        public int PersonAge { get { return age; } set { age = value; } }
        public string PersonName { get; set; }

        static PersonClass()
        {
            a = 10;
            Console.WriteLine("this is static constructor");
        }
        // Default Constructor
        public PersonClass()
         {
            age = 0;
            Console.WriteLine(" Default Constructor invoked");
         }
        // parametrized Constructor
        public PersonClass(int Age)
        {
            PersonAge = Age;
            Console.WriteLine("\n Parametrized  Constructor invoked");

        }
        public PersonClass(int Age , String Name, string gender)
        {
            gen = gender;
            PersonAge = Age;
            PersonName = Name;
            Console.WriteLine("\n Constructor overloadeded");

        }

        //Copy Constructor

        public PersonClass (PersonClass p)
        {
            PersonName = p.PersonName;
            PersonAge = p.PersonAge;
            gen = p.gen;

            Console.WriteLine("Name :" + PersonName);
            Console.WriteLine("Name :" + PersonAge + " Gender " +gen );
        }

        // Method
        public void SetName( string value)
        {
            PersonName = value;
        }
        public void GetName()
        {
            Console.WriteLine(" " + PersonName);
        }
        public void Message(string message)
        {
            Console.WriteLine(" " + message);
        }
    }

}
