using System;
using System.Security.Cryptography.X509Certificates;

namespace Point
{
	struct Point
	{
		public double X;
		public double Y;

		public override string ToString()
		{
			return "(" + X + ", " + Y + ")";
		}
	}
}
