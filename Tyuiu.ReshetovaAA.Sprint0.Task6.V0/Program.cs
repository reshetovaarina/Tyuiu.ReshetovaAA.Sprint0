using Tyuiu.ReshetovaAA.Sprint0.Task6.V0.Lib;
int[] arraynums = new int[] { 1, 2, 3, 4, 5 };
Console.WriteLine("Сумма элементов массив = " + DataService.AdditionArray(arraynums));
Console.WriteLine("Разность элемнтов массив = " + DataService.SubtractionArray(arraynums));
Console.WriteLine("Произведение элемнтов массива = " + DataService.MultiplicationArray(arraynums));
Console.ReadKey();