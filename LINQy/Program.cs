using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQy
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<Student> studentList = new List<Student>()
            //{
            //new Student() {StudentID = 1, StudentName = "John", Age = 13},
            //new Student() {StudentID = 2, StudentName = "Moin",  Age = 21},
            //new Student() {StudentID = 3, StudentName = "Bill",  Age = 18},
            //new Student() {StudentID = 4, StudentName = "Ram" , Age = 20},
            //new Student() {StudentID = 5, StudentName = "Ron" , Age = 15}
            //};
            //find student above 15
            //List<Student> studentsAboveFifteen = new List<Student>();
            //foreach (var student in studentList)
            //{
            //    if (student.Age>15)
            //    {
            //        studentsAboveFifteen.Add(student);
            //    }
            //}

            //var studentsAboveFifteen = from s in studentList
            //                           where s.Age > 15
            //                           select s;
            //var studentsAboveFifteen = studentList.Where(st => st.Age > 15);
            //var printOut = studentsAboveFifteen.ToList().Print();
            //Console.WriteLine(printOut);
            List<People> people = new List<People>()
            {
                new People{Name="Dara", Balance=30000M},
                new People{Name="Mary", Balance=3001M},
                new People{Name="Jane", Balance=25300M},
                new People{Name="Ben", Balance=2005M},
                new People{Name="Sam", Balance=3101M}
            };
            List<Winner> winners = new List<Winner>()
            {
                new Winner { Name="Mary", Award=30000000M},
                new Winner { Name="Sam", Award=25300000M}
            };
            //get the balance of people who are winners
            //var winnersInPeopleQuery = people.Join(winners, p => p.Name, w => w.Name, (people, winners) =>
            //    new { Name = people.Name, Balance = people.Balance, Award = winners.Award });
            //List<WinningPeople> winnersInPeople = new List<WinningPeople>();
            //winnersInPeople = winnersInPeopleQuery.ToList();
            //foreach (var winner in winnersInPeopleQuery)
            //{
            //    Console.WriteLine($"Winner: {winner.Name} won {winner.Award:c} with a previous balance of {winner.Balance:c}!");
            //}

            var joinQuery = from p in people
                            join w in winners
                            on p.Name equals w.Name
                            select new WinningPeople()
                            { Name = p.Name, Balance = p.Balance, Award = w.Award };
            Console.WriteLine(joinQuery.ToList().Print());
        }
    }
    class WinningPeople
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public decimal Award { get; set; }

    }
    class People
    {
        public string Name { get; set; }
        public decimal Balance { get; set; }
    }
    class Winner
    {
        public string Name { get; set; }
        public decimal Award { get; set; }
    }
}
