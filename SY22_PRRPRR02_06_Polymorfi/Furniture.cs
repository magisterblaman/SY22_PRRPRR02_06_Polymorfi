using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_06_Polymorfi {
	internal class Furniture {
		private string _color;
		protected double _width;
		protected double _height;
		protected double _depth;

		public Furniture(string inputColor, 
			double inputWidth, 
			double inputHeight, 
			double inputDepth) {

			_color = inputColor;
			_width = inputWidth;
			_height = inputHeight;
			_depth = inputDepth;
		}

		public virtual void Use() {
			Console.WriteLine("Du använde möbeln");
		}
	}
}
