using System;
using System.Collections.Generic;
using System.Linq;
using DemoLibrary.Models;

namespace DemoLibrary.DataAccess
{
	public interface IDataAccess
	{
		List<PersonModel> GetPeople();
		PersonModel InsertPerson(string firstName, string lastName);
	}

	public class DemoDataAccess : IDataAccess
	{
		private List<PersonModel> people = new();

		public DemoDataAccess()
		{
			people.Add(new PersonModel { Id = 1, FirstName = "Felipe", LastName = "Cabeza" });
			people.Add(new PersonModel { Id = 2, FirstName = "John", LastName = "Doe" });
		}

		public List<PersonModel> GetPeople()
		{
			return people;
		}

		public PersonModel InsertPerson(string firstName, string lastName)
		{
			PersonModel p = new() { FirstName = firstName, LastName = lastName };
			p.Id = people.Max(x => x.Id) + 1;
			people.Add(p);
			return p;
		}
	}
}
