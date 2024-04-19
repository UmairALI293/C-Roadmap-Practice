
namespace C__Roadmap_Practice
{
    public struct Persons
    {
        private int age;
        private string name;

        public Persons(int A_Value, string N_Value)
        {
            age = A_Value;
            name = N_Value;
        }

        public void ShowPerson() 
        {
            Console.WriteLine(" using struct ");
            Console.WriteLine(" " + name);
            Console.WriteLine(" " + age);
          
        }


        //public int Age
        //{
        //    get { return age; }

        //    set { age = value; }


        //}
        //public string Name
        //{
        //    get { return name;}

        //    set { name = value; }
        //}

    }
}
