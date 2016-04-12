using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace TanHex{
	
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class HexCell : MonoBehaviour {
		float outerR = 1;
		float innerR;

		Mesh hexMesh;

		public float OuterR {
			get {return outerR;}
		}

		public float InnerR {
			get {return (Mathf.Sqrt(3)/2)*outerR;}
		}
	
		void Start(){
			GetComponent<MeshFilter>().mesh = hexMesh = new Mesh();
			hexMesh.name = "Hex Mesh";
			hexMesh.vertices = GetVertices();
			hexMesh.triangles = GetTriangles();
		}

		Vector3[] GetVertices() {
			return new Vector3[]{
				new Vector3(0f, 0f, 0f),
				new Vector3(0f, 0f, OuterR),
				new Vector3(InnerR, 0f, 0.5f * OuterR),
				new Vector3(InnerR, 0f, -0.5f * OuterR),
				new Vector3(0f, 0f, -OuterR),
				new Vector3(-InnerR, 0f, -0.5f * OuterR),
				new Vector3(-InnerR, 0f, 0.5f * OuterR)
			};
		}

		int[] GetTriangles() {
			return new int[]{
				0, 1, 2,
				0, 2, 3,
				0, 3, 4,
				0, 4, 5,
				0, 5, 6,
				0, 6, 1
			}
		}
	}

}
