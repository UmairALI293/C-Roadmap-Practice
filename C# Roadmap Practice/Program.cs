
// icluding namespace
using C__Roadmap_Practice;

// 9. Enumeration
public enum D_Types
{
    Val_Type=1, Ref_Type
}
public class program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Enter 1 for ValType or 2 for RefType");
        D_Types typ1 = (D_Types)int.Parse(Console.ReadLine());
        switch (typ1)
        {
            case D_Types.Val_Type:
                Console.WriteLine(typ1);
                Persons person = new Persons(24, "umair");
                person.ShowPerson();
                //person.Name = "umair";
                //person.Age = 24;
                //Console.WriteLine(person.Name);
                //Console.WriteLine(person.Age);

                break;

            case D_Types.Ref_Type:

                Console.WriteLine("enter 1 for Default or 2 for parameterized constructor");
                int num = int.Parse(Console.ReadLine());

                if (num == 1)
                {
                    Console.WriteLine("\n Using Class ");
                    PersonClass person1 = new PersonClass();
                    person1.PersonAge = 30;
                    person1.SetName("Zain");
                    person1.GetName();
                    Console.WriteLine(" " + person1.PersonAge);
                    person1.Message("i am internee");
                }

                else if (num == 2)
                {
                    Console.WriteLine("\n Using Class ");
                    PersonClass person2 = new PersonClass(24);
                    person2.SetName("Usman");

                    person2.GetName();
                    Console.WriteLine(" " + person2.PersonAge);
                    person2.Message("i am internee");

                    person2 = new PersonClass(30, "UMAIR_ALI", "Male");
                    person2.GetName();
                    Console.WriteLine(" " + person2.PersonAge);
                    //PersonClass person3 = person2;

                    PersonClass person3 = new PersonClass(person2);
                    person2.age = 50;
                    Console.WriteLine(person3.age);

                }
                break;
        }
    }
}