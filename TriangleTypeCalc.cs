namespace TriangleType
{
    /// <summary>
    /// Расчёт типа треугольника по трем известным сторонам
    /// </summary>
    public class TriangleTypeCalc
    {
        /// <summary>
        /// Расчёт типа треугольника
        /// </summary>
        /// <param name="sideA">Сторона A</param>
        /// <param name="sideB">Сторона B</param>
        /// <param name="sideC">Сторона C</param>
        /// <returns>Тип треугольника</returns>
        public string GetTriangleType(double sideA, double sideB, double sideC)
        {
            if (sideA + sideB > sideC && sideA + sideC > sideB && sideB + sideC > sideA && sideA > 0 && sideB > 0 && sideC > 0)
            {
                if ((sideA * sideA).Equals(sideB * sideB + sideC * sideC) ||
                    (sideB * sideB).Equals(sideA * sideA + sideC * sideC) ||
                    (sideC * sideC).Equals(sideA * sideA + sideB * sideB))
                {
                    return "Треугольник является прямоугольным";
                }
                
                if (sideA * sideA > sideB * sideB + sideC * sideC ||
                         sideB * sideB > sideA * sideA + sideC * sideC ||
                         sideC * sideC > sideA * sideA + sideB * sideB)
                {
                    return "Треугольник является тупоугольным";
                }

                return "Треугольник является остроугольным";
            }

            return "Треугольник не существует";
        }
    }
}
