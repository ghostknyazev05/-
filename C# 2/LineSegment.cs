using System;

namespace Section
{
    public class LineSegment
    {
        private double _x;
        private double _y;

        // Свойства для доступа к координатам 
        public double X { get => _x; set => _x = value; }
        public double Y { get => _y; set => _y = value; }

        // Конструктор
        public LineSegment(double _x, double _y)
        {
            this._x = _x;
            this._y = _y;
        }

        // Метод проверки, попадает ли точка в отрезок 
        public bool Contains(double point)
        {
            double min = Math.Min(_x, _y);
            double max = Math.Max(_x, _y);
            return point >= min && point <= max;
        }

        // Перегрузка ToString() для отображения отрезка
        public override string ToString()
        {
            return $"Отрезок:[{_x},{_y}]";
        }
    }
}
