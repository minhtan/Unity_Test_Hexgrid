using UnityEngine;
using System.Collections;

namespace Tan{
	public class HexCell : MonoBehaviour {
		CellStatus status;
		public HexCell(CellStatus status){
			this.status = status;
		}
	}
}
