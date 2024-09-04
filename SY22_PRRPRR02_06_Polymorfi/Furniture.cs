using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_06_Polymorfi {
	internal class Furniture {
		public string color;
		public double width;
		public double height;
		public double depth;

		public Furniture(string inputColor, 
			double inputWidth, 
			double inputHeight, 
			double inputDepth) {

			color = inputColor;
			width = inputWidth;
			height = inputHeight;
			depth = inputDepth;
		}

		public virtual void Use() {
			Console.WriteLine("Du använde möbeln");
		}
	}
}
