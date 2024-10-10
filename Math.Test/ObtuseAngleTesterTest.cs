﻿using Math.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Math.Test
{
    [TestClass]
    public class ObtuseAngleTesterTest
    {
        [TestMethod]
        public void AngleIsObtuse()
        {
            IObtuseAngleTester obtuseAngleTester = new ObtuseAngleTester();

            double[] vector1 = new double[3] { 0, 1, 0};
            double[] vector2 = new double[3] { 0, -0.9, 0.1 };

            bool isObtuse = obtuseAngleTester.AngleIsOver90Degree(vector1, vector2);

            Assert.IsTrue(isObtuse);
        }

        [TestMethod]
        public void AngleIsNotObtuse()
        {
            IObtuseAngleTester obtuseAngleTester = new ObtuseAngleTester();

            double[] vector1 = new double[3] { 0, 1, 0 };
            double[] vector2 = new double[3] { 0, 0.9, 0.1 };

            bool isObtuse = obtuseAngleTester.AngleIsOver90Degree(vector1, vector2);

            Assert.IsFalse(isObtuse);
        }

        [TestMethod]
        public void Test()
        {
            IObtuseAngleTester obtuseAngleTester = new ObtuseAngleTester();

            double[] vector1 = new double[3] { 0, 1, 0 };
            double[] vector2 = new double[3] { 0, 1, 0 };
            double[] vector3 = new double[3] { 0, -0.9, 0.1 };
            double[] vector4 = new double[3] { 0, -1, 0 };
            double[] vector5 = new double[3] { 1, 0, 0 };

            double[] vector6 = new double[3] { 0, 0, 1 };

            bool isObtuse = obtuseAngleTester.AngleIsOver90Degree(vector1, vector2);
            isObtuse = obtuseAngleTester.AngleIsOver90Degree(vector1, vector3);
            isObtuse = obtuseAngleTester.AngleIsOver90Degree(vector1, vector4);
            isObtuse = obtuseAngleTester.AngleIsOver90Degree(vector1, vector5);
            isObtuse = obtuseAngleTester.AngleIsOver90Degree(vector1, vector6);
            Assert.IsFalse(false);
        }
    }
}
