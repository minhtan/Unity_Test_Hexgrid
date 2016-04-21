using UnityEngine;
using System.Collections;
namespace Tan{
	public struct HexCoordinates {
		public int Row { get; private set; }
		public int Col { get; private set; }
		public HexCoordinates (int row, int col) {
			Row = row;
			Col = col;
		}
	}

	public enum CellStatus{
		FREE,
		BLOCKED
	}

	public struct MapCoor{
		public int row;
		public int col;
		public MapCoor(int row, int col){
			this.row = row;
			this.col = col;
		}
	}

	public class HexData {
		static float outerR = 1;
		public static float OuterR {
			get {return outerR;}
		}

		static float innerR = (Mathf.Sqrt(3)/2)*outerR;
		public static float InnerR {
			get {return innerR;}
		}
	}
}
