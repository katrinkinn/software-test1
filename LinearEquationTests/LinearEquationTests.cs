using NUnit.Framework;
using LinearEquation;
using System;

namespace Tests
{
    public class LinearEquationTests
    {
        [Test]
        public void FormatExceptionTest()
        {
            double[,] A = new double[,] { { 10, 2, 3, 4 }, { 2, 4, 5, 6 }, { -5, 7, 8, 9 }, { 6, 1, 4, 3 }, { 2, 0, 5, 6 } };
            double[] B = new double[] { 1, 3, 6, 9 };
            LinearEquationSystem system;
            Assert.Throws<FormatException>(() => system = new LinearEquationSystem(A,B));
        }

        [Test]
        public void ArgumentExceptionTest()
        {
            double[,] A = { { 0, 0 }, { 0, 0 } };
            double[] B = { 0, 0 };
            LinearEquationSystem system = new LinearEquationSystem(A, B);
            Assert.Throws<ArgumentException>(() => system.Solve());
        }

        [Test]
        public void TwodimensionalArrayTest()
        {
            double[,] A = { { 1, 2 }, { 1, 3 } };
            double[] B = { 2, 1 };
            double[] expected = { 4, -1 };
            LinearEquationSystem system = new LinearEquationSystem(A, B);
            var actual = system.Solve();
            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void ThreedimensionalArrayTest()
        {
            double[,] A = { { 2, 1, -1 }, { 3, 2, 2 }, { 1, 0, 1 } };
            double[] B = { 3, -7, -2 };
            double[] expected = { 1, -2, -3 };
            LinearEquationSystem system = new LinearEquationSystem(A, B);
            var actual = system.Solve();
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}