// <copyright file="Program.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

/// <summary>
/// this class is our Hello class that has SayHello static method.
/// </summary>
public static class Hello
{ /// <summary>
      /// this is the method called Sayhello that will return string 'Hello, World!'.
      /// </summary>
      /// <returns></returns>
    public static string Sayhello()
    {
        return "Hello, World!";
    }
}

public static class Program
{
    public static void Main()
    {
        Console.WriteLine(Hello.Sayhello());
    }
}