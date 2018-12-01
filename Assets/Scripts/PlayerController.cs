/*
Controls player interaction
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Camera mainCam;
	private float playerZ;
	
	void Start () {
		mainCam = Camera.main;
		playerZ = this.transform.position.z;
	}
	
	void FixedUpdate () {
		MovePlayer();
	}
	
	private void MovePlayer() {
		float xLimitLeft = mainCam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
		float xLimitRigh = mainCam.ViewportToWorldPoint(new Vector3(1, 1, 0)).x;
		float xChange = Input.GetAxis("Horizontal");
		float newX = Mathf.Clamp(this.transform.position.x + xChange, xLimitLeft, xLimitRigh);
		float newY = this.transform.position.y;
		float newZ = playerZ;

		this.transform.position = new Vector3(newX, newY, newZ);
	}
}
