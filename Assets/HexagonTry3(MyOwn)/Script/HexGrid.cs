using UnityEngine;
using System.Collections;

namespace Tan{
	public struct MapCoor{
		public int row;
		public int col;
		public MapCoor(int row, int col){
			this.row = row;
			this.col = col;
		}
	}

	public class HexGrid : MonoBehaviour {
		int[][] grid;
		public int rowNo = 5;
		public int colNo = 5;

		void Start(){
			MapCoor mc = RectHexMap.HexCoorToMap (new HexCoordinates (2, 0));
			Debug.Log (mc.row + " " + mc.col);
		}
	}
}
