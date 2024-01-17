

using ChallangeApp;

User user1 = new User("Slawek", "HJBJLHHLJL");
User user2 = new User("Juanusz","hjblhlj");
User user3 = new User("Jacek", "ghkkjljj");

user1.AddScore(4);
user1.AddScore(2);
var result = user1.Result;
Console.WriteLine(result);





