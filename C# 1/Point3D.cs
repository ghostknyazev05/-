using System;

namespace GeometryNamespace
{
    // Класс Point3D наследует от базового класса BaseClass
    public class Point3D : BaseClass
    {
        // Конструктор, принимающий координаты X, Y и Z
        public Point3D(double x, double y, double z) : base(x, y, z) { }

        // Конструктор копирования, создающий новый объект Point3D на основе другого
        public Point3D(Point3D other) : base(other) { }

       
        public override string ToString()
        {
            return $"Point3D координаты: X = {field1}, Y = {field2}, Z = {field3}";
        }

        // Метод для вычисления расстояния от точки до начала координат (0, 0, 0)
        public double DistanceToOrigin()
        {
            return Math.Sqrt(field1 * field1 + field2 * field2 + field3 * field3);
        }

       // Метод, который используется для того, чтобы узнать, находиться ли точка на оси Х
        public bool IsOnXAxis()
        {
            return field2 == 0 && field3 == 0; 
        }

        // Метод для вычисления угла с осью Z
        public double CalculateAngleWithZAxis()
        {
            double dotProduct = field3; 
            double magnitude = Math.Sqrt(field1 * field1 + field2 * field2 + field3 * field3); 
            double cosTheta = dotProduct / magnitude;
            double angleInRadians = Math.Acos(cosTheta); 
            return angleInRadians * (180 / Math.PI); 
        }

        
        public override void Print()
        {
            Console.WriteLine(ToString());
        }
    }
}
