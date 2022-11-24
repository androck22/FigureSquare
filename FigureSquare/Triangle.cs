namespace FigureSquare
{
	public class Triangle
	{
		private readonly Lazy<bool> _isRightTriangle;
		public double SideA { get; }
		public double SideB { get; }
		public double SideC { get; }
		public bool IsRightTriangle => _isRightTriangle.Value;
		public Triangle(double sideA, double sideB, double sideC)
		{
			if (sideA <= 0 | sideB <= 0 | sideC <= 0)
			{
				throw new ArgumentOutOfRangeException("The side of the triangle can't be negative or 0");
			}

			SideA = sideA;
			SideB = sideB;
			SideC = sideC;

			_isRightTriangle = new Lazy<bool>(GetIsRightTriangle);
		}


		public double GetSquare()
		{
			var semiperimeter = (SideA + SideB + SideC) / 2d;
			var square = Math.Sqrt(semiperimeter * (semiperimeter - SideA) * (semiperimeter - SideB) * (semiperimeter - SideC));

			return square;
		}

		private bool GetIsRightTriangle()
		{
			if (SideA > SideB && SideA > SideC)
			{
				if (Math.Pow(SideB, 2) + Math.Pow(SideC, 2) == Math.Pow(SideA, 2))
				{
					return true;
				}
			}
			else if (SideB > SideA && SideB > SideC)
			{
				if (Math.Pow(SideA, 2) + Math.Pow(SideC, 2) == Math.Pow(SideB, 2))
				{
					return true;
				}
			}
			else if (SideC > SideA && SideC > SideB)
			{
				if (Math.Pow(SideA, 2) + Math.Pow(SideB, 2) == Math.Pow(SideC, 2))
				{
					return true;
				}
			}

			return false;
		}
	}
}
