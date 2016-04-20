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

	public class HexCell : MonoBehaviour {
		
	}
}
