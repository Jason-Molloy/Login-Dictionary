using System.Collections.Generic;
using System;
using userlogin.Models;

namespace userlogin
{
  class App
  {
    Dictionary<string, User> Users { get; set; }
    bool LoggedIn { get; set; }

    public void run()
    {
      Console.WriteLine("Welcome. Please enter your userName");
      while (!LoggedIn)
      {
        string name = Console.ReadLine();
        System.Console.Write("Password: ");
        string pass = Console.ReadLine();
        Login(name, pass);
        if (LoggedIn) { continue; };
        Console.Clear();
        System.Console.WriteLine("INVALID CREDENTIALS, TRY AGAIN");
      }
      System.Console.WriteLine("Successfully Logged In!");
    }

    private bool Login(string name, string pass)
    {
      return Users.ContainsKey(name) && Users[name].ValidatePassword(pass);

    }
    public App()
    {
      Users = new Dictionary<string, User>();
      User mark = new User("Mark", "IHeartCode");
      User jake = new User("Jake", "MarkIsTheBest");
      Users.Add(mark.Name, mark);
      Users.Add(jake.Name, jake);
    }
  }
}


// Users = {
//   Mark:{
//     Name: "Mark",
//     ValidatePassword: {}
//   }
// }