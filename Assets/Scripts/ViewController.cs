using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewController : MonoBehaviour {

	public float playerLayer;

	private GameObject playerObject;
	private Camera mainCam;
	
	// Use this for initialization
	void Start () {
		Screen.SetResolution(700, 1000, false);
		GameObject[] playerObjects = GameObject.FindGameObjectsWithTag("Player");
		if(playerObjects == null) {
			// Handle missing PO
		} else if(playerObjects.Length > 1) {
			// Delete all POs except first
		} else {
			playerObject = playerObjects[0];
		}

		mainCam = Camera.main;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		lerpCameraIfPlayerDescended();
	}

	private void lerpCameraIfPlayerDescended() {
		float cameraY = mainCam.transform.position.y;
		float playerObjectY = playerObject.transform.position.y;
		if(playerObjectY <= cameraY) {
			Vector3 cameraPos = new Vector3(
				mainCam.transform.position.x,
				cameraY,
				mainCam.transform.position.z
			);
			Vector3 destination = new Vector3(
				mainCam.transform.position.x,
				playerObjectY,
				mainCam.transform.position.z
			);
			mainCam.transform.position = Vector3.Lerp(cameraPos, destination, 1);
		}
	}
}
