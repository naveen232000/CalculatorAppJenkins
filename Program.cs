// See https://aka.ms/new-console-template for more information
using CalculatorApp;
using static CalculatorApp.Calculate;

Console.WriteLine("Calculator Results");
double num1 = 56, num2=23;
Calculate cal = new Calculate();
del addnum = new del(cal.Add);
addnum(num1, num2);
del subNum = new del(cal.Sub);
subNum(num1, num2);
del divNum = new del(cal.Div);
divNum(num1, num2);
del multiNum = new del(cal.Multi);
multiNum(num1, num2);
del AvgNum = new del(cal.Avg);
AvgNum(num1, num2);








//cal.Add(num1,num2);
//cal.Sub(num1, num2);
//cal.Multi(num1, num2);
//cal.Div(num1, num2);
