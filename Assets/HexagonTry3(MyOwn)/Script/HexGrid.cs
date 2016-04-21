using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace Tan{
	public class HexGrid : MonoBehaviour {
		Dictionary<HexCoordinates, HexCell> cells = new Dictionary<HexCoordinates, HexCell>();
		public int rowNo = 5;
		public int colNo = 5;
		GameObject tempGo;
		public GameObject cellPrefab;

		void Start(){
			CreateCells ();
		}

		HexCell GetCell(HexCoordinates coor){
			HexCell cell;
			if (cells.TryGetValue (coor, out cell)) {
				return cell;
			} else {
				return null;
			}
		}

		HexCell CreateCell(int x, int z, int y = 0, CellStatus status = CellStatus.FREE){
			tempGo = Instantiate (cellPrefab);
			tempGo.transform.SetParent (transform, false);

			Vector3 pos;
			pos.x = x * HexData.InnerR;
			pos.y = y;
			pos.z = z * 1.5f * HexData.OuterR;
			tempGo.transform.localPosition = pos;

			return tempGo.GetComponent<HexCell> ();
		}

		void CreateCells(){
			for(int r=0; r < rowNo; r++){
				for(int c=0; c <colNo; c++){
					cells.Add (RectHexMap.MapToHexCoor(r, c), CreateCell(c, r));
				}
			}
		}

	}
}
