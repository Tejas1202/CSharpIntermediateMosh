using CSharpIntermediateConsoleApp.Classes.Exercises;
using System;

namespace CSharpIntermediateConsoleApp.Classes
{
    class CallerClass
    {
        public void IntroToClasses()
        {
            //Simple object declaration and usage
            var person = new Person();
            person.Name = "John";
            person.Introduce("Mosh");

            //Usage of Instance member Parse method which doesn't makes any sense here
            var personOne = new Person(); //personOne's Name property remains null as it has never been assigned
            var p = personOne.Parse("Jim"); //Doing F11 here, Name property in Person class will be null, but NameTwo will not be null as it's static
            p.Introduce("Mosh");

            //Usage of static member Parse method (Correct way)
            var personTwo = Person.StaticParse("Jimmy");
            personTwo.Introduce("Mosh");

            //Random calling
            var personThree = Person.StaticParse("Johnny"); //personThree's name property won't be changed after the next line as we're returning a new object from StaticParse method
            Person.StaticParse("JohnnyTwo");

            Console.WriteLine(person.Name + " " + personOne.Name + " " + p.Name + " " + personTwo.Name + " " + personThree.Name);
        }

        public void Constructors()
        {
            var order = new Order();
            var customer = new Customer(2, "Tj");
            customer.Orders.Add(order);
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
        }

        public void ObjectInitializers()
        {
            //Will call our parameterless constructor and assign Orders member a value
            var customer = new Customer
            {
                Id = 1,
                Name = "Tj",
            };

            var order = new Order();
            customer.Orders.Add(order);

            var customerOne = new Customer(1, "Tj");
        }

        public void IntroToMethods()
        {
            var parameterModifiers = new ParameterModifiers();
            var a = 1;
            parameterModifiers.DoAWeirdThing(ref a);
            parameterModifiers.ConvertToInt("Abc");

            try
            {
                var point = new Point(10, 20);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
                point.Move(new Point(40, 60)); //So here, first the constructor will be called and X and Y will be reset to their default values, and then the method Move is called
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
                point.Move(100, 200);
                Console.WriteLine("Point is at ({0},{1})", point.X, point.Y);
            }
            catch (Exception)
            {
                Console.WriteLine("An unexpected error occured");
            }

            Console.WriteLine(parameterModifiers.Add(1,2));
            Console.WriteLine(parameterModifiers.Add(1,2,3,4));
            Console.WriteLine(parameterModifiers.Add(new int[] { 1, 2, 3, 4, 5 }));
        }

        public void Fields()
        {
            var car = new Car(4033);
            car.Orders.Add(new Order());
            car.Orders.Add(new Order());
            car.Promote(); //So here, again the Orders list will get reset hence to avoid situations like that, make the field readonly
            Console.WriteLine(car.Orders.Count);
        }

        public void AccessModifiers()
        {
            var employee = new Employee(new DateTime(1996, 02, 12));
            Console.WriteLine(employee.Age);
            employee.SetProjectDate(new DateTime(2017, 11, 16));
            Console.WriteLine(employee.GetProjectDate());
        }

        public void Indexers()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Mosh";
            Console.WriteLine(cookie["name"]);
            Console.WriteLine(cookie["nam"]);
        }

        public void ExerciseOne()
        {
            bool isContiued = true;
            var exercise = new Stopwatch();

            while (isContiued)
            {
                Console.WriteLine("Press enter to start time - other key to exit");
                if(Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    exercise.Start();
                    Console.WriteLine("Press enter to stop time - Escape to exit - Any other key to continue");
                    var readKeyForStop = Console.ReadKey().Key;
                    if(readKeyForStop == ConsoleKey.Enter)
                    {
                        exercise.Stop();
                        Console.WriteLine("Total time taken: " + exercise.Duration);
                        Console.WriteLine("===================================================");
                    }
                    else if(readKeyForStop == ConsoleKey.Escape)
                    {
                        isContiued = false;
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    isContiued = false;
                }
            }
        }

        public void ExerciseTwo()
        {
            Console.WriteLine("Ask a question");
            Console.WriteLine("Enter title"); 
            var title = Console.ReadLine();
            Console.WriteLine("Enter description");
            var description = Console.ReadLine();
            var post = new Post(title, description);
            bool isContinued = true;
            while (isContinued)
            {
                Console.WriteLine("Press 1 to Upvote, 2 to Downvote and 3 to Exit");
                var input = Console.ReadKey().Key;
                Console.WriteLine();

                switch (input)
                {
                    case ConsoleKey.NumPad1:
                        post.UpVote();
                        break;
                    case ConsoleKey.NumPad2:
                        post.DownVote();
                        break;
                    case ConsoleKey.NumPad3:
                        isContinued = false;
                        break;
                    default:
                        Console.WriteLine("Sorry, couldn't understand your input");
                        break;
                }
            }

            Console.WriteLine("Total number of votes received: " + post.Votes);
        }
    }
}
