using InspectorLib;
using System;
using System.Collections.Generic;
namespace Final2
{
    public class Class1
    {
        public static void Main(string[] args)
    {
        Console.WriteLine($"Название автоинспекции: {FunctionInsp.GetCarInspection()}");
        Console.WriteLine($"Главный инспектор: {FunctionInsp.GetInspector()}");

        bool inspectorChanged = FunctionInsp.SetInspector("Зиронов Т.А.");
        Console.WriteLine($"Инспектор изменен: {inspectorChanged}");
        Console.WriteLine($"Новый главный инспектор: {FunctionInsp.GetInspector()}");


        string generatedNumber = FunctionInsp.GenerateNumber('А');
        Console.WriteLine($"Сгенерированный госномер: {generatedNumber}");


        List<string> workers = FunctionInsp.GetWorker();
        Console.WriteLine("Список сотрудников:");
        foreach (string worker in workers)
        {
            Console.WriteLine(worker);
        }

        bool workerAdded = FunctionInsp.AddWorker("Петров П.П.");
        Console.WriteLine($"Сотрудник добавлен: {workerAdded}");

        workers = FunctionInsp.GetWorker();
        Console.WriteLine("\nСписок сотрудников после добавления:");
        foreach (string worker in workers)
        {
            Console.WriteLine(worker);
        }
    }
    }
}
