using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace TanHex{
	public static class HexData {
		#region metric
		static float outerR = 1;
		public static float OuterR {
			get {return outerR;}
		}

		static float innerR = (Mathf.Sqrt(3)/2)*outerR;
		public static float InnerR {
			get {return innerR;}
		}
		#endregion

		#region vertices, trangles, uv
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
		#endregion

		#region coordinate conversion
		public static Vector2 CoordCubeToAxial(Vector3 cubeCord){
			float q = cubeCord.x;
			float r = cubeCord.z;
			return new Vector2 (q, r);
		}

		public static Vector3 CoordAxialToCube(Vector2 axialCord){
			float x = axialCord.x;
			float z = axialCord.y;
			float y = -x - z;
			return new Vector3 (x, y, z);
		}
		#endregion

		#region neighbor hexes
		public enum Direction{
			TopRight,
			Right,
			BotRight,
			BotLeft,
			Left,
			TopLeft
		};

		static Dictionary<Direction, Vector2> axialDirection = new Dictionary<Direction, Vector2> () {
			{Direction.TopRight, new Vector2(1, -1)},
			{Direction.Right, new Vector2(1, 0)},
			{Direction.BotRight, new Vector2(0, 1)},
			{Direction.BotLeft, new Vector2(-1, 1)},
			{Direction.Left, new Vector2(-1, 0)},
			{Direction.TopLeft, new Vector2(0, -1)}
		};
		public static Dictionary<Direction, Vector2> AxialDirection {
			get {return axialDirection;}
		}

		public static Vector2 HexNeighbor(Vector2 hex, Direction dir) {
			Vector2 value;
			if (AxialDirection.TryGetValue (dir, out value)) {
				return hex + value;
			} else {
				return hex;
			}
		}
		#endregion

		#region distance
		public static float AxialDistance(Vector2 a, Vector2 b){
			return Mathf.Max (
				Mathf.Abs(a.x - b.x),
				Mathf.Abs(a.y - b.y),
				Mathf.Abs(a.x + a.y - b.x - b.y)
			);
		}
		#endregion
	}
}