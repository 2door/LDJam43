/*
Controls player interaction
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Camera mainCam;
	private Rigidbody2D playerRigidBody;
	private GameplayController gameplayController;
	private float playerZ;
	
	void Start () {
		mainCam = Camera.main;
		playerRigidBody = GetComponent<Rigidbody2D>();
		gameplayController = GameplayController.gameplayController;
		playerZ = this.transform.position.z;
	}
	
	void FixedUpdate () {
		MovePlayer();
	}
	
	private void MovePlayer() {
		float xChange = Input.GetAxis("Horizontal") * gameplayController.horizontalSpeedFactor;
		float xLimitLeft = mainCam.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
		float xLimitRigh = mainCam.ViewportToWorldPoint(new Vector3(1, 1, 0)).x;
		float newX = Mathf.Clamp(this.transform.position.x + xChange, xLimitLeft, xLimitRigh);
		float newY = this.transform.position.y;
		float newZ = playerZ;

		this.transform.position = new Vector3(newX, newY, newZ);
	}
}
