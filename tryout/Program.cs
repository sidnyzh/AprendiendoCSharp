// See https://aka.ms/new-console-template for more information
using tryout;

Console.WriteLine("Hello, World!");

List<Person> people = new List<Person>();
people.Add(new Person("Juan", new DateTime(1996, 02, 04), 'M')); 
people.Add(new Person("Camilo", new DateTime(1999, 10, 04),'M')); 
people.Add(new Person("Sidny", new DateTime(1993, 12, 10), 'F')); 
people.Add(new Person("Julian", new DateTime(1978, 06, 01),'M')); 
people.Add(new Person("Julio", new DateTime(1987, 03, 20),'M')); 
people.Add(new Person("Dary", new DateTime(2000, 01, 12), 'F')); 
people.Add(new Person("Yessica", new DateTime(1986, 10, 22),'F')); 
people.Add(new Person("Haudy", new DateTime(1995, 02, 19),'M')); 
people.Add(new Person("steisy", new DateTime(2001, 12, 08),'F')); 
people.Add(new Person("Camila", new DateTime(2002, 09, 30),'F')); 
people.Add(new Person("Duván", new DateTime(1996, 02, 04),'M')); 
people.Add(new Person("Salem", new DateTime(2021, 01, 14),'M')); 
people.Add(new Person("Bigotes", new DateTime(2021, 10, 26),'M')); 
people.Add(new Person("Brisa", new DateTime(2022, 02, 04),'F')); 
people.Add(new Person("Neil", new DateTime(1996, 03, 24),'M')); 
people.Add(new Person("Raven", new DateTime(1980, 08, 07),'F')); 
people.Add(new Person("Rue", new DateTime(1983, 02, 18),'F')); 
people.Add(new Person("Cassie", new DateTime(1990, 11, 27),'F')); 
people.Add(new Person("Maddie", new DateTime(1975, 03, 15),'F')); 
people.Add(new Person("Bellamy", new DateTime(1992, 08, 11),'M')); 
people.Add(new Person("Eliza", new DateTime(2005, 12, 12),'F')); 
people.Add(new Person("Carol", new DateTime(1986, 07, 18),'F')); 
people.Add(new Person("Lexie", new DateTime(2001, 06, 02),'F')); 
people.Add(new Person("Fezco", new DateTime(1998, 05, 07),'M')); 
people.Add(new Person("Neil", new DateTime(1974, 12, 29),'M')); 
people.Add(new Person("Fraileón", new DateTime(1920, 08, 30),'M')); 
people.Add(new Person("Wendy", new DateTime(2000, 11, 07),'F')); 
people.Add(new Person("Valentina", new DateTime(1999, 11, 23),'F')); 
people.Add(new Person("Dayana", new DateTime(1995, 05, 16),'F')); 
people.Add(new Person("Melissa", new DateTime(2019, 10, 25),'F')); 
people.Add(new Person("Natalia", new DateTime(1994, 11, 02),'F')); 
people.Add(new Person("Dahiana", new DateTime(1991, 07, 06),'F'));
people.Add(new Person("Ernesto Perez", new DateTime(1882, 03, 06),'M'));

Person person = new Person();




List<Person> overAges=  person.OverAge(people);
List<Person> underAges = person.UnderAge(people);
List<Person> females = person.Female(people);
List<Person> males = person.Male(people);
List<Person> overAgeFemales = person.OverAgeFemale(people);
Console.WriteLine("Aoy una crack");





