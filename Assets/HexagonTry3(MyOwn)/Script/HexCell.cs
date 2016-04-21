using UnityEngine;
using System.Collections;

namespace Tan{
	[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
	public class HexCell : MonoBehaviour {
		Mesh hexMesh;
		public Texture texture;

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
