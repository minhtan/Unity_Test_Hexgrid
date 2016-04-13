using UnityEngine;
using System.Collections;

namespace TanHex{
	public class HexGrid : MonoBehaviour {
		void Start(){
			Debug.Log (HexData.AxialDistance(new Vector2(-1, 0), new Vector2(2, -2)));
		}
	}
}

//http://forum.unity3d.com/threads/open-source-procedural-hexagon-terrain.233296/
//http://www.redblobgames.com/grids/hexagons/