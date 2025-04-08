using System;

namespace Section
{
    public class LineSegment
    {
        private double x;
        private double y;

        // Свойства для доступа к координатам 
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        // Конструктор
        public LineSegment(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Метод проверки, попадает ли точка в отрезок 
        public bool Contains(double point)
        {
            double min = Math.Min(x, y);
            double max = Math.Max(x, y);
            return point >= min && point <= max;
        }

        // Перегрузка ToString() для отображения отрезка
        public override string ToString()
        {
            return $"Отрезок:[{x},{y}]";
        }
    }
}