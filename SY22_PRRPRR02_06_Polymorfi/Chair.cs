using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_06_Polymorfi {
	internal class Chair : Furniture {

		public int NumberOfLegs;
		public double ComfortLevel;

		public Chair(string inputColor,
			double inputWidth,
			double inputHeight,
			double inputDepth,
			int inputLegs,
			double inputComfort) : base(inputColor, inputWidth, inputHeight, inputDepth) {

			NumberOfLegs = inputLegs;
			ComfortLevel = inputComfort;
		}

		public override void Use() {
			Console.WriteLine("Du använde stolen. Den har en komfort på " + ComfortLevel);
		}

	}
}
