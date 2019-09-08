using System;
using System.Collections.Generic;
using System.IO;

namespace GroupList
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] lines = File.ReadAllLines(@"C:\Users\prymn\Documents\list.txt");
			foreach(var line in lines)
			{
				Console.WriteLine(line);
			}

			List<Person> students = new List<Person>();
			foreach(var line in lines)
			{
				var names = line.Split(' ');
				var person = new Person(names[0], names[1]);

				students.Add(person);
			}

			foreach (var student in students)
			{
				Console.WriteLine(student.LastName + ", " + student.FirstName);
			}
		}
	}
}
