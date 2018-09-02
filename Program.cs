using System;
using System.Collections.Generic;

namespace lists
{
  class Program
  {
    static void Main(string[] args)
    {
      // HASH SETS
      // What's cool about em?
      // You can't have duplicates
      // They're not stored in any particular order
      HashSet<int> grades = new HashSet<int>()
      {
          75,
          97,
          51,
          83
      };

      grades.Add(75);
      //   Console.WriteLine(grades.Count);

      // Loop through teh grades
      //   foreach (int number in grades)
      //   {
      //     Console.WriteLine(number);
      //   }

      // Creat a new set of grades
      HashSet<int> secondGrades = new HashSet<int>()
    {
        40,
        89,
        50,
        97
    };


      // Combine the two sets of grades
      //   grades.UnionWith(secondGrades);
      //   Console.WriteLine(grades.Count);

      // create a copy of the original grades hashset (because IntersectWith modifies the original)
      HashSet<int> commonGrades = new HashSet<int>(grades);

      // Now we can safely use IntersectWith to find the common entries between the two hashsets
      commonGrades.IntersectWith(secondGrades);

      //   foreach (int item in commonGrades)
      //   {
      //     Console.WriteLine(item);
      //   }




      // DICTIONARIES
      // When should you use it?
      // Cannot include duplicate or null keys
      // Create dictionary of strings
      Dictionary<string, string> teacherNames = new Dictionary<string, string>()
      {
          {"LeadInstructor", "Steve"},
          {"JuniorInstructor", "Emily"},
          {"TA", "Jordan"},
      };

      //LOOPING THROUGH DICTIONARIES
      // The elements inside of dictionaries are KeyValuePairs<type, type>
      // Inside a key value pair, you can access the key with item.Key and the value with item.value

      //   foreach (KeyValuePair<string, string> c in teacherNames)
      //   {
      //     Console.WriteLine($"The {c.Key} is {c.Value}");
      //   }

      // If you know specifically what you're looking for inside a dictionary, you can also do dictionaryName["keyName"]

      //   Console.WriteLine(teacherNames["LeadInstructor"]);
      //   Console.WriteLine(teacherNames["TA"]);


      // FRANKEN DATA!!!!!
      // A dictionary of hashsets and the hashsets have ints inside
      // AAAAAAHHHHH
      Dictionary<string, HashSet<int>> studentIds = new Dictionary<string, HashSet<int>>(){
          {"Ms. Jarell's Class", new HashSet<int>()
          {
              199,
              133,
              400,
              500
          }
          },
        {"Ms. Miller's Class", new HashSet<int>()
          {
              6000,
              203,
              300,
              200
          }
          }
      };

      //   foreach (KeyValuePair<string, HashSet<int>> currentClass in studentIds)
      //   {
      //     string sentenceAboutClass = $"{currentClass.Key} has the following id's: ";
      //     foreach (int studentId in currentClass.Value)
      //     {
      //       sentenceAboutClass += studentId + " ";
      //     }
      //     System.Console.WriteLine(sentenceAboutClass);

      //   }

      //LISTS
      // This is a list of dictionaries
      // The dictionaries have strings in them

      List<Dictionary<string, string>> studentList = new List<Dictionary<string, string>>()
      {
          new Dictionary<string, string>{
              {"Jewel", "April 13"},
              {"Michael", "June 25"}
          },
          new Dictionary<string, string>{
              {"Ronnie", "April 42"},
              {"Rachel", "June 100"}
          }
      };

      // The first loop iterates through the dictionaries
      foreach (Dictionary<string, string> currentCohort in studentList)
      {
        // The nested loop iterates through the KeyValueParis INSIDE each dictionary
        foreach (KeyValuePair<string, string> currentStudent in currentCohort)
        {
          // Inside a key value pair, you can access the key with .Key and the value with .Value
          Console.WriteLine($"{currentStudent.Key}'s birthday is {currentStudent.Value}");
        }
      }

      // THE END

    }
  }
}
