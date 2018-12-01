/*
Controls player interaction
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	void Start () {
	}
	
	void FixedUpdate () {
		MovePlayer();
	}
	
	private void MovePlayer() {
		this.transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0);
	}
}
