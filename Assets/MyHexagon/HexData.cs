using UnityEngine;
using System.Collections;

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

		#region conversion
		public static Vector2 CubeToAxialCord(Vector3 cubeCord){
			float q = cubeCord.x;
			float r = cubeCord.z;
			return new Vector2 (q, r);
		}

		public static Vector3 AxialToCubeCord(Vector2 axialCord){
			float x = axialCord.x;
			float z = axialCord.y;
			float y = -x - z;
			return new Vector3 (x, y, z);
		}
		#endregion

		#region navigation

		#endregion
	}
}