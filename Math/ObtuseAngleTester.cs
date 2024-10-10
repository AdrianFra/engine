using Math.Contracts;

namespace Math
{
    public sealed class ObtuseAngleTester : IObtuseAngleTester
    {
        bool IObtuseAngleTester.AngleIsOver90Degree(double[] vector1, double[] vector2)
        {
            double result = vector1[0] * vector2[0] + vector1[1] * vector2[1] + vector1[2] * vector2[2];
            return result <= 0;
        }
    }
}
