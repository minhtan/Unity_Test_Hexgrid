using UnityEngine;
using System.Collections;

namespace Tan{
	public class RectHexMap : MonoBehaviour {
		static public HexCoordinate MapToHexCoor(int row, int col, bool isOddOffset = true){
			int offset = isOddOffset ? 1 : 0;
			return new HexCoordinate (row, col - Mathf.FloorToInt((row+offset)/2));
		}

		static public MapCoordinate HexCoorToMap(HexCoordinate coor, bool isOddOffset = true){
			int offset = isOddOffset ? 1 : 0;
			return new MapCoordinate (coor.Row, coor.Col + ((coor.Row+offset)/2));
		}
	}
}
