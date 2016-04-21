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

		static Vector3[] vertices = new Vector3[]{
			new Vector3(0f, 0f, OuterR),
			new Vector3(InnerR, 0f, 0.5f * OuterR),
			new Vector3(InnerR, 0f, -0.5f * OuterR),
			new Vector3(0f, 0f, -OuterR),
			new Vector3(-InnerR, 0f, -0.5f * OuterR),
			new Vector3(-InnerR, 0f, 0.5f * OuterR)
		};
		public static Vector3[] Vertices {
			get {return vertices;}
		}

		static int[] triangles = new int[] {
			0,1,2,
			0,2,5,
			5,2,3,
			5,3,4
		};
		public static int[] Triangles {
			get {return triangles;}
		}

		static Vector2[] uv = new Vector2[] {
			new Vector2(0.5f, 1f),
			new Vector2(1f, 0.75f),
			new Vector2(1f, 0.25f),
			new Vector2(0.5f, 0f),
			new Vector2(0f, 0.25f),
			new Vector2(0f, 0.75f),
		};
		public static Vector2[] Uv {
			get {return uv;}
		}
	}
}
