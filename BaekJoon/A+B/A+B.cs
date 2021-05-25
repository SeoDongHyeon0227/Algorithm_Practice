using System;

class MainClass {
  public static void Main (string[] args) {
    string[] a = Console.ReadLine().Split();
    Console.Write(Convert.ToInt32(a[0]) + Convert.ToInt32(a[1]));
  }
}