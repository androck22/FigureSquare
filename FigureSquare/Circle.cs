namespace FigureSquare
{
	public class Circle : IFigure
	{
		public double Radius { get; }
		public Circle(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(radius),"Circle radius can't be negative or 0");
			}

			Radius = radius;
		}

		public double GetSquare()
		{
			return Math.PI * Math.Pow(Radius, 2d);
		}
	}
}
