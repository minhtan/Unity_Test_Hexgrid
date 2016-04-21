using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Tan{
	public class HexGrid : MonoBehaviour {
		Dictionary<HexCoordinate, HexCell> cells = new Dictionary<HexCoordinate, HexCell>();
		public int rowNo = 5;
		public int colNo = 5;
		GameObject tempGo;
		public GameObject cellPrefab;

		void Start(){
			CreateCells ();
		}

		HexCell GetCell(HexCoordinate coor){
			HexCell cell;
			if (cells.TryGetValue (coor, out cell)) {
				return cell;
			} else {
				return null;
			}
		}

		HexCell CreateCell(int z, int x, int y = 0){
			tempGo = Instantiate (cellPrefab);
			tempGo.transform.SetParent (transform, false);

			Vector3 pos;
			pos.x = (x * 2 - (z % 2)) * HexData.InnerR;
			pos.y = y;
			pos.z = (z * 1.5f) * HexData.OuterR;
			tempGo.transform.localPosition = pos;

			return tempGo.GetComponent<HexCell> ();
		}

		void CreateCells(){
			for(int r=0; r < rowNo; r++){
				for(int c=0; c < colNo; c++){
					cells.Add (RectHexMap.MapToHexCoor(r, c), CreateCell(r, c));
				}
			}
		}

	}
}
