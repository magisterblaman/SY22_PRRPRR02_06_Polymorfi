using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_06_Polymorfi {
	internal class Table : Furniture {

		public int NumberOfLegs;
		public string Texture;
		public int NumberOfSeats;

		public Table(string inputColor,
			double inputWidth,
			double inputHeight,
			double inputDepth,
			int inputLegs,
			string inputTexture,
			int inputSeats) : base(inputColor, inputWidth, inputHeight, inputDepth) {

			NumberOfLegs = inputLegs;
			Texture = inputTexture;
			NumberOfSeats = inputSeats;
		}

	}
}
