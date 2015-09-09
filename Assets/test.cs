using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	private GameObject cube;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * 1f);
	}
}
