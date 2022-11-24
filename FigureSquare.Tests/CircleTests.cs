namespace FigureSquare.Tests
{
	public class CircleTests
	{
		[Fact]
		public void CirclePositiveRadiusTest()
		{
			// arrange 
			var radius = 15;
			var circle = new Circle(radius);
			var expectedValue = Math.PI * Math.Pow(radius, 2d);

			// act
			var actualValue = circle.GetSquare();

			// assert
			Assert.Equal(expectedValue, actualValue);
		}

		[Fact]
		public void CircleZeroRadiusTest()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(0));
		}

		[Fact]
		public void CircleNegativeRadiusTest()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-2));
		}
	}
}