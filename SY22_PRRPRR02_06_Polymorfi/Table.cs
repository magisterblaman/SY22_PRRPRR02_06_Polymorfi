using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_06_Polymorfi {
	internal class Table : Furniture {

		public int numberOfLegs;
		public string texture;
		public int numberOfSeats;

		public Table(string inputColor,
			double inputWidth,
			double inputHeight,
			double inputDepth,
			int inputLegs,
			string inputTexture,
			int inputSeats) : base(inputColor, inputWidth, inputHeight, inputDepth) {

			numberOfLegs = inputLegs;
			texture = inputTexture;
			numberOfSeats = inputSeats;
		}

	}
}
