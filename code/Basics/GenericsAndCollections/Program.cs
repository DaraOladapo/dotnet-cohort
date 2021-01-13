using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace GenericsAndCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Student<NameOnly> studentNamesOnly = new Student<NameOnly>();
            studentNamesOnly.Data = new NameOnly() { Name = "Dara" };
            Console.WriteLine(studentNamesOnly.Data.Name);

            Student<FirstNameLastName> studentFirstNameLastName = new Student<FirstNameLastName>();
            studentFirstNameLastName.Data = new FirstNameLastName() { FirstName = "Dara", LastName = "Oladapo" };
            Console.WriteLine(studentFirstNameLastName.Data.FullName);

            Student<FirstNameLastName[]> studentFirstNameLastNameArray = new Student<FirstNameLastName[]>();
            studentFirstNameLastNameArray.Data = new FirstNameLastName[3];
            studentFirstNameLastNameArray.Data[0] = new FirstNameLastName() { FirstName = "Dara", LastName = "Oladapo" };
            studentFirstNameLastNameArray.Data[1] = new FirstNameLastName() { FirstName = "Dare", LastName = "Oladapo" };
            studentFirstNameLastNameArray.Data[2] = new FirstNameLastName() { FirstName = "Daro", LastName = "Oladapo" };
            foreach (var item in studentFirstNameLastNameArray.Data)
            {
                Console.WriteLine(item.FullName);
            }

            //collection objects
            List<FirstNameLastName> Students = new List<FirstNameLastName>();
            Students.Add(new FirstNameLastName { FirstName = "Smith", LastName = "Anderson" });
            Students.AddRange(studentFirstNameLastNameArray.Data);


            //ObservableCollection<FirstNameLastName> observableStudents = new ObservableCollection<FirstNameLastName>();

        }
    }
    class Multiple<TKey, TValue, TDescription>
    {
        public TKey Key { get; set; }
        public TValue Value { get; set; }
        public TDescription Description { get; set; }
    }
    class Student<T>
    {
        public T Data { get; set; }
    }
    class NameOnly
    {
        public string Name { get; set; }
    }
    class FirstNameLastName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
    }
}
