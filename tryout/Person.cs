using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryout
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Birthdate { get; set; }
        public char Sex { get; set; }

         
        public Person(string name, DateTime birthdate, char sex)
        {
            Name = name;
            Birthdate = birthdate;
            Age = accurateAge(birthdate);
            Sex = sex;
        }

        public Person()
        {
        }
        private int accurateAge(DateTime DateOfBirth)
        {
            int year = DateTime.Now.Year - DateOfBirth.Year;
            int month = DateTime.Now.Month - DateOfBirth.Month;
            int day = DateTime.Now.Day - DateOfBirth.Day;
            if (month < 0)
            {
                return year - 1;
            }
            else if (month == 0)
            {
                return day <=0 ? year - 1: year;
            }
            else
            {
                return year;
            }
        }
        public List<Person> OverAge(List<Person> people)
        {
            List<Person> overAgePeople = people.Where(person => person.Age >=18).ToList();
            return overAgePeople;
        }
        public List<Person> UnderAge(List<Person> people)
        {
            List<Person> underAgePeople = people.Where(person => person.Age < 18).ToList();
            return underAgePeople;
        }
        public List<Person> Female(List<Person> people)
        {
            List<Person> femalePeople = people.Where(person  => person.Sex == 'F').ToList();
            return femalePeople;
        }
        public List<Person> Male(List<Person> people)
        {
            List<Person> malePeople = people.Where(person => person.Sex == 'F' ).ToList();
            return malePeople;
        }

        public List<Person> OverAgeFemale(List<Person> people)
        {
            List<Person> overAgeFemales = people.Where(person => person.Age >= 18 && person.Sex == 'F').ToList();
            return overAgeFemales;
        }
        public bool BelongsToTheList(string name, List<Person> people)
        {
            bool belongs = people.Select(person => person.Name == name).Any();
            return belongs;
        }
    }   

}
