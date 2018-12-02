using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmController : MonoBehaviour {

	private Camera mainCam;

	void Start () {
		mainCam = Camera.main;
	}
	
	void Update () {
		pointToMouse(this.transform);
	}

	// Move to Utility
	private void pointToMouse(Transform target) {
		Vector2 mousePosition = Input.mousePosition;
		Vector2 objectPosition = mainCam.WorldToScreenPoint(target.position);
		mousePosition = mousePosition - objectPosition;
		float angle = (Mathf.Atan2(mousePosition.y, mousePosition.x) * Mathf.Rad2Deg) + 90.0f;
		Debug.Log("Target rotation initial: " + target.rotation);
		target.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
		Debug.Log("Target rotation after: " + target.rotation);
		Debug.Log("Mouse at: " + mousePosition);
		Debug.Log("Angle: " + angle);
	}
}
