using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SY22_PRRPRR02_06_Polymorfi {
	internal class Program {
		static void Main(string[] args) {

			Chair chair = new Chair("red", 50.0, 80.0, 50.0, 4, 100.0);
			Table table = new Table("white", 110.0, 70.0, 60.0, 2, "scrowly", 30);

			List<Chair> chairs = new List<Chair>() {
				new Chair("blue", 50.0, 80.0, 50.0, 3, 47.3),
				new Chair("yellow", 50.0, 40.0, 50.0, 2, 200.0),
				new Chair("brown", 50.0, 40.0, 50.0, 2, 200.0),
			};

			Furniture furniture = new Chair("red", 50.0, 80.0, 50.0, 4, 100.0);

			//furniture = new Table("white", 110.0, 70.0, 60.0, 2, "scrowly", 30);

			Chair chair2 = (Chair)furniture;

			List<Furniture> furnitures = new List<Furniture>() {
				new Chair("blue", 50.0, 80.0, 50.0, 3, 47.3),
				new Chair("yellow", 50.0, 40.0, 50.0, 2, 200.0),
				new Chair("brown", 50.0, 40.0, 50.0, 2, 200.0),
				new Table("white", 110.0, 70.0, 60.0, 2, "scrowly", 30)
			};

			for (int i = 0; i < furnitures.Count; i++) {
				Furniture f = furnitures[i];
				f.Use();
			}
		}
	}
}
