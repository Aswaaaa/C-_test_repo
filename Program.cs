using System;
using MyCSharpAPP.Math;

namespace MyCSharpAPP
{
    class Program{
    static void Main(string[] args){
        var person = new Person();
        person.FirstName = "Aswa";
        person.LastName = " ";
        person.Introduce();

        Calculator calculator = new Calculator();
        int result = calculator.Add(1,5);
        System.Console.WriteLine(result);
    }
}
}