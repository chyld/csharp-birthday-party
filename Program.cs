using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace sweet
{
  class Program
  {
    static void Main(string[] args)
    {
      var people = new List<Person>();
      var lines = File.ReadAllLines("guests.csv");

      foreach (var line in lines)
      {
        var array = line.Split(',');
        var name = array[0];
        var age = ushort.Parse(array[1]);
        var person = new Person() { Name = name, Age = age };
        people.Add(person);
      }

      var invites = from p in people where p.Age >= 21 select p;

      foreach (var i in invites)
      {
        Console.WriteLine($"{i} is invited to the party!");
      }
    }
  }
}
