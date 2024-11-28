using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InspectorLib;
namespace Test
{
    internal class TestInsp
    {
        static void Main(string[] args)
        {
            FunctionInsp insp = new FunctionInsp();

            // Тестирование метода GetInspector
            Console.WriteLine("\nГлавный инспектор: " + insp.GetInspector());

            // Тестирование метода GetCarInspection
            Console.WriteLine("\nНазвание автоинспекции: " + insp.GetCarInspection());

            // Тестирование метода SetInspector
            Console.WriteLine("\nТекущий главный инспектор: " + insp.GetInspector());
            insp.SetInspector("Куйбышев А.Е.");
            Console.WriteLine("Новый главный инспектор: " + insp.GetInspector());

            // Тестирование метода GenerateNumber
            Console.WriteLine("\nСлучайный номер: " + insp.GenerateNumber());

            // Тестирование метода GetWorker
            string[] workers = insp.GetWorker();
            Console.WriteLine("\nСписок сотрудников:");
            foreach (string worker in workers)
            {
                Console.WriteLine(worker);
            }

            // Тестирование метода AddWorker
            Console.WriteLine("\nДобавляем сотрудника: 'Новиков Н.Н.'");
            insp.AddWorker("Новиков Н.Н.");
            Console.WriteLine("Обновленный список сотрудников:");
            workers = insp.GetWorker();
            foreach (string worker in workers)
            {
                Console.WriteLine(worker);
            }

            Console.ReadLine();
        }
    }
}
