using System;

Console.WriteLine("Укажите рост:");
Int32.TryParse(Console.ReadLine(),out int height_cm);
Console.WriteLine("Укажите вес:");
Int32.TryParse(Console.ReadLine(),out int mass);
if(height_cm <= 0 || mass <= 0)
 throw new Exception("Неверные данные! Повторите попытку.");
float height = (float)height_cm / 100;
var result = new BMI(mass,height);
Console.WriteLine($"ИМТ = {result.Index:N2} - {result.Interpritation}");
