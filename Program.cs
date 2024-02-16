// See https://aka.ms/new-console-template for more information
using CalculatorApp;

Console.WriteLine("Calculator Results");

double num1 = 25;
double num2 = 50;
Calculate cal =new Calculate();
cal.Add(num1,num2);
cal.Sub(num1, num2);
cal.Multi(num1, num2);
cal.Div(num1, num2);
