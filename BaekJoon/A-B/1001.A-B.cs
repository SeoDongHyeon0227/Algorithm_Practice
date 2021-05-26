using System;

class MainClass {
  public static void Main (string[] args) {
    string[] a = (Console.ReadLine()).Split();


    Console.WriteLine(int.Parse(a[0]) - int.Parse(a[1]));
  }
}