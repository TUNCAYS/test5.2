using UnityEngine;
using System.Collections;
using UnityEngine.Advertisements;
using UnityEngine.Analytics;

public class test : MonoBehaviour {

	private GameObject cube;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * 1f);

		if (Input.GetMouseButton (0)) {
			if(Advertisement.IsReady()){
				Advertisement.Show();
				Analytics.CustomEvent("click",null);
			}
		}

	}
}
