using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_06_Polymorfi {
	internal class Chair : Furniture {

		public int numberOfLegs;
		public double comfortLevel;

		public Chair(string inputColor,
			double inputWidth,
			double inputHeight,
			double inputDepth,
			int inputLegs,
			double inputComfort) : base(inputColor, inputWidth, inputHeight, inputDepth) {

			numberOfLegs = inputLegs;
			comfortLevel = inputComfort;
		}

		public override void Use() {
			Console.WriteLine("Du använde stolen. Den har en komfort på " + comfortLevel);
		}

	}
}
