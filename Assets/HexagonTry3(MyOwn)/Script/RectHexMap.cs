using UnityEngine;
using System.Collections;

namespace Tan{
	public class RectHexMap : MonoBehaviour {
		static public HexCoordinates MapToHexCoor(int row, int col){
			return new HexCoordinates (row, col - Mathf.FloorToInt((row+1)/2));
		}

		static public MapCoor HexCoorToMap(HexCoordinates coor){
			return new MapCoor (coor.Row, coor.Col + ((coor.Row+1)/2));
		}
	}
}
