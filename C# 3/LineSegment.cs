namespace Section
{
    public class LineSegment
    {
        private double __x;
        private double __y;

        public double _x { get => _x; set => _x = value; }
        public double _y { get => _y; set => _y = value; }

        public LineSegment() { _x = 0; _y = 0; }

        public LineSegment(double _x, double _y)
        {
            this._x = _x;
            this._y = _y;
        }

        // Проверка, попадает ли точка в отрезок
        public bool Contains(double point)
        {
            double min = Math.Min(_x, _y);
            double ma_x = Math.Max(_x, _y);
            return point >= min && point <= ma_x;
        }

        public override string ToString()
        {
            return $"Отрезок: [{_x:F3}, {_y:F3}]";
        }

        // Унарный оператор ! — вычисление длины отрезка
        public static double operator !(LineSegment segment)
        {
            return Math.Abs(segment._y - segment._x);
        }

        // Унарный оператор ++ — увеличение координат отрезка на 1
        public static LineSegment operator ++(LineSegment segment)
        {
            segment._x += 1;
            segment._y += 1;
            return segment;
        }

        // Явное приведение к int — вернуть целую часть _x
        public static explicit operator int(LineSegment segment)
        {
            return (int)segment._x;
        }

        // Неявное приведение к double — вернуть _y
        public static implicit operator double(LineSegment segment)
        {
            return segment._y;
        }

        // Бинарный оператор + (увеличивает обе координаты на d)
        public static LineSegment operator +(LineSegment segment, int d)
        {
            return new LineSegment(segment._x + d, segment._y + d);
        }

        // Перегрузка обратного + (int + LineSegment)
        public static LineSegment operator +(int d, LineSegment segment)
        {
            return new LineSegment(segment._x + d, segment._y + d);
        }
    }
}
