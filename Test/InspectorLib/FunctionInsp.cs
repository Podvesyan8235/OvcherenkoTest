using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InspectorLib
{
    public class FunctionInsp
    {
        private string chiefInspector = "Васильев Василий Иванович";
        private string autoInspectionName = "Автоинспекция г. Чита";
        private string[] workers =
        {
            "Иванов И.И.",
            "Зиронов Т.А.",
            "Миронов А.В.",
            "Васильев В.И."
        };

        //  ФИО главного инспектора
        public string GetInspector()
        {
            return chiefInspector;
        }

        // Метод возвращает название автоинспекции
        public string GetCarInspection()
        {
            return autoInspectionName;
        }

        // Изменяет ФИО главного инспектора
        public void SetInspector(string Newname)
        {
            chiefInspector = Newname;
        }

        // Формирует госномер 
        public string GenerateNumber()
        {
            Random random = new Random();

            // Генерация буквы
            char symbol = (char)random.Next('A', 'Z' + 1);

            // Генерация трехзначного числа
            int number = random.Next(100, 1000);

            // Код региона (фиксированный)
            string regionCode = "75";

            // Формирование полного номера
            return $"{symbol} {number} {regionCode}";
        }

        // Возвращает список сотрудников
        public string[] GetWorker()
        {
            return workers;
        }

        // Добавляет нового сотрудника в массив
        public void AddWorker(string name)
        {
            // Увеличиваем массив и добавляем нового сотрудника
            int Size = workers.Length;
            string[] newWorkers = new string[Size + 1];
            for (int i = 0; i < Size; i++)
            {
                newWorkers[i] = workers[i];
            }
            newWorkers[Size] = name;
            workers = newWorkers;
        }
    }
}
