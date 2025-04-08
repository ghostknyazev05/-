namespace Section
{
    public class LineSegment
    {
        private double x;
        private double y;

        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }

        public LineSegment() { x = 0; y = 0; }

        public LineSegment(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        // Проверка, попадает ли точка в отрезок
        public bool Contains(double point)
        {
            double min = Math.Min(x, y);
            double max = Math.Max(x, y);
            return point >= min && point <= max;
        }

        public override string ToString()
        {
            return $"Отрезок: [{x:F3}, {y:F3}]";
        }

        // Унарный оператор ! — вычисление длины отрезка
        public static double operator !(LineSegment segment)
        {
            return Math.Abs(segment.y - segment.x);
        }

        // Унарный оператор ++ — увеличение координат отрезка на 1
        public static LineSegment operator ++(LineSegment segment)
        {
            segment.x += 1;
            segment.y += 1;
            return segment;
        }

        // Явное приведение к int — вернуть целую часть X
        public static explicit operator int(LineSegment segment)
        {
            return (int)segment.x;
        }

        // Неявное приведение к double — вернуть Y
        public static implicit operator double(LineSegment segment)
        {
            return segment.y;
        }

        // Бинарный оператор + (увеличивает обе координаты на d)
        public static LineSegment operator +(LineSegment segment, int d)
        {
            return new LineSegment(segment.x + d, segment.y + d);
        }

        // Перегрузка обратного + (int + LineSegment)
        public static LineSegment operator +(int d, LineSegment segment)
        {
            return new LineSegment(segment.x + d, segment.y + d);
        }
    }
}