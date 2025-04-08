using System;

namespace GeometryNamespace
{
    // Интерфейс 
    public interface IPrintable
    {
        void Print(); // Метод для вывода информации
        string ToString(); // Метод для получения строкового представления объекта
    }

    // Класс Base, который реализует интерфейс IPrintable
    public class BaseClass : IPrintable
    {
        // Создание защищенных полей, которые могут быть использованы в этом или производных от базового класса
        protected double field1;
        protected double field2;
        protected double field3;

        // Метод инициализации переменных значениями
        public BaseClass(double a, double b, double c)
        {
            field1 = a;
            field2 = b;
            field3 = c;
        }

        // Метод копирования значений
        public BaseClass(BaseClass other)
        {
            field1 = other.field1;
            field2 = other.field2;
            field3 = other.field3;
        }

        // Метод получения последних цифр чисел
        public virtual int GetMaxLastDigit()
        {
            int last1 = Math.Abs((int)field1) % 10;
            int last2 = Math.Abs((int)field2) % 10;
            int last3 = Math.Abs((int)field3) % 10;
            return Math.Max(last1, Math.Max(last2, last3));
        }

        // Реализация метода интерфейса IPrintable
        public virtual void Print()
        {
            Console.WriteLine(ToString()); // Вывод информации о базовом классе
        }

        // Реализация метода ToString из интерфейса IPrintable
        public override string ToString()
        {
            return $"BaseClass поля: field1 = {field1}, field2 = {field2}, field3 = {field3}";
        }
    }
}
