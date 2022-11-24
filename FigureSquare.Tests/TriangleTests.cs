namespace FigureSquare.Tests
{
	public class TriangleTests
	{
		[Fact]
		public void TrianglePositiveSideTest()
		{
			// arrange 
			var sideA = 6;
			var sideB = 5;
			var sideC = 4;

			var triangle = new Triangle(sideA, sideB, sideC);
			var semiperimeter = (sideA + sideB + sideC) / 2d;
			var expectedValue = Math.Sqrt(semiperimeter * (semiperimeter - sideA) * (semiperimeter - sideB) * (semiperimeter - sideC));

			// act
			var actualValue = triangle.GetSquare();

			// assert
			Assert.Equal(expectedValue, actualValue);
		}

		[Fact]
		public void TriangleZeroSideTest()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(0, 5, 6));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(3, 0, 6));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(4, 5, 0));
		}

		[Fact]
		public void TriangleNegativeSideTest()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-2, 5, 6));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, -5, 6));
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(2, 5, -6));
		}

		[Fact]
		public void RightAngleTriangleTest()
		{
			// arrange 
			var sideA = 3;
			var sideB = 5;
			var sideC = 4;

			var triangle = new Triangle(sideA, sideB, sideC);

			// act
			var actualValue = triangle.IsRightTriangle;

			// assert
			Assert.True(actualValue);
		}

		[Fact]
		public void NotRightAngleTriangleTest()
		{
			// arrange 
			var sideA = 6;
			var sideB = 2;
			var sideC = 4;

			var triangle = new Triangle(sideA, sideB, sideC);

			// act
			var actualValue = triangle.IsRightTriangle;

			// assert
			Assert.False(actualValue);
		}
	}
}
