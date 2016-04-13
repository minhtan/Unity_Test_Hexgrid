using UnityEngine;
using System.Collections;
using System.Collections.Generic;

namespace TanHex{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class HexCell : MonoBehaviour {
		public Texture texture;
		Mesh hexMesh;

		void Start(){
			GetComponent<MeshFilter>().mesh = hexMesh = new Mesh();
			hexMesh.name = "Hex Mesh";

			hexMesh.vertices = HexData.Vertices;
			hexMesh.triangles = HexData.Triangles;
			hexMesh.uv = HexData.Uv;

			hexMesh.RecalculateNormals ();
			GetComponent<MeshRenderer> ().material.mainTexture = texture;
		}
			
	}
}
