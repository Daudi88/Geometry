using NUnit.Framework;
using Geometry;
using System;

namespace GeometryTests
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        GeometryCalculator calculator = new();

        [TestCase(4, 16)]
        [TestCase(0.1f, 0.01f)]
        [TestCase(20.3f, 412.09f)]
        [TestCase(0.2f, 0.04f)]
        [TestCase(0, 0)]
        [TestCase(-5, 0)]
        public void AreaTest_Square(float side, float expected)
        {
            // Arrange
            var square = new Square { Side = side };

            // Act
            var actual = square.Area();

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [TestCase(2, 4, 8)]
        [TestCase(4, 8, 32)]
        [TestCase(0, 0, 0)]
        [TestCase(-4, 8, 0)]
        [TestCase(4, -8, 0)]
        public void AreaTest_Rectangle(
            float height,
            float width,
            float expected)
        {
            // Arrange
            var rectangle = new Rectangle { Height = height, Width = width };

            // Act
            var actual = rectangle.Area();

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [TestCase(3, 28.274334f)]
        [TestCase(6.3f, 124.689827f)]
        [TestCase(0, 0)]
        [TestCase(-1, 0)]
        public void AreaTest_Circle(float radius, float expected)
        {
            // Arrange
            var circle = new Circle { Radius = radius };

            // Act
            var actual = circle.Area();

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [TestCase(5, 12, 30)]
        [TestCase(23, 10, 115)]
        [TestCase(0, 0, 0)]
        [TestCase(-23, 10, 0)]
        [TestCase(23, -10, 0)]
        public void AreaTest_Triangle(
            float tBase,
            float height,
            float expected)
        {
            // Arrange
            var triangle = new Triangle { Base = tBase, Height = height };

            // Act
            var actual = triangle.Area();

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [TestCase(4, 16)]
        [TestCase(0.1f, 0.4f)]
        [TestCase(0, 0)]
        [TestCase(-2, 0)]
        public void PerimiterTest_Square(float side, float expected)
        {
            // Arrange
            var square = new Square { Side = side };

            // Act
            var actual = square.Perimiter();

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [TestCase(2, 4, 12)]
        [TestCase(2.5f, 4.2f, 13.4f)]
        [TestCase(4, 8, 24)]
        [TestCase(0, 8, 0)]
        [TestCase(4, 0, 0)]
        [TestCase(-4, 8, 0)]
        [TestCase(4, -8, 0)]
        public void PerimiterTest_Rectangle(float height, float width, float expected)
        {
            // Arrange
            var rectangle = new Rectangle { Height = height, Width = width };

            // Act
            var actual = rectangle.Perimiter();

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [TestCase(3, 18.84956f)]
        [TestCase(6.3f, 39.58407f)]
        [TestCase(0, 0)]
        [TestCase(-2.5f, 0)]
        public void PerimiterTest_Circle(float radius, float expected)
        {
            // Arrange
            var circle = new Circle { Radius = radius };

            // Act
            var actual = circle.Perimiter();

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [TestCase(5, 15)]
        [TestCase(2.3f, 6.9f)]
        [TestCase(0, 0)]
        [TestCase(-14, 0)]
        public void PerimiterTest_Triangle(float tBase, float expected)
        {
            // Arrange
            var triangle = new Triangle { Base = tBase };

            // Act
            var actual = triangle.Perimiter();

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [Test]
        public void GetPerimitersTest_ValidArray1()
        {
            // Arrange
            var things = new GeometricThing[]
            {
                new Square { Side = 4 },
                new Rectangle { Height = 2, Width = 4 },
                new Circle { Radius = 3 },
                new Triangle { Base = 5 }
            };
            var expected = 61.849556f;

            // Act
            var actual = calculator.GetPerimiters(things);

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [Test]
        public void GetPerimitersTest_ValidArray2()
        {
            // Arrange
            var things = new GeometricThing[]
            {
                new Square { Side = 5 },
                new Rectangle { Height = 2.5f, Width = 4.2f },
                new Circle { Radius = 6.3f },
                new Triangle { Base = 2.3f }
            };
            var expected = 79.88407f;

            // Act
            var actual = calculator.GetPerimiters(things);

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [Test]
        public void GetPerimitersTest_InvalidArray1()
        {
            // Arrange
            var things = new GeometricThing[]
            {
                new Square { Side = 0 },
                new Rectangle { Height = -2.5f, Width = 4.2f },
                new Circle { Radius = 0 },
                new Triangle { Base = -2.3f }
            };
            var expected = 0.0f;

            // Act
            var actual = calculator.GetPerimiters(things);

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [Test]
        public void GetPerimitersTest_InvalidArray2()
        {
            // Arrange
            GeometricThing[] things = null;
            var expected = 0.0f;

            // Act
            var actual = calculator.GetPerimiters(things);

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [Test]
        public void GetPerimitersTest_InvalidArray3()
        {
            // Arrange
            var things = new GeometricThing[0];
            var expected = 0.0f;

            // Act
            var actual = calculator.GetPerimiters(things);

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [Test]
        public void GetAreasTest_ValidArray1()
        {
            // Arrange
            var things = new GeometricThing[]
            {
                new Square { Side = 4 },
                new Rectangle { Height = 2, Width = 4 },
                new Circle { Radius = 3 },
                new Triangle { Base = 5, Height = 12 }
            };
            var expected = 82.274334f;

            // Act
            var actual = calculator.GetAreas(things);

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [Test]
        public void GetAreasTest_ValidArray2()
        {
            // Arrange
            var things = new GeometricThing[]
            {
                new Square { Side = 0.1f },
                new Rectangle { Height = 4, Width = 8 },
                new Circle { Radius = 6.3f },
                new Triangle { Base = 23, Height = 10 }
            };
            var expected = 271.699827f;

            // Act
            var actual = calculator.GetAreas(things);

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [Test]
        public void GetAreasTest_InvalidArray1()
        {
            // Arrange
            GeometricThing[] things = null;
            var expected = 0.0f;

            // Act
            var actual = calculator.GetAreas(things);

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

        [Test]
        public void GetAreasTest_InvalidArray2()
        {
            // Arrange
            var things = new GeometricThing[0];
            var expected = 0.0f;

            // Act
            var actual = calculator.GetAreas(things);

            // Assert
            Assert.That(Math.Round(actual, 2), Is.EqualTo(Math.Round(expected, 2)));
        }

    }
}