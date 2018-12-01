/*
Controls gameplay changes.
Stores modifiers for difficulty and stats.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayController : MonoBehaviour {

	public static GameplayController gameplayController;
	public float horizontalSpeedFactor;
	public float jumpHeight;

	void Start () {
		
	}

	void Awake() {
		if (gameplayController == null) {
			DontDestroyOnLoad(this.gameObject);
			gameplayController = this;
		} else if (gameplayController != this) {
			Destroy(this.gameObject);
		}
	}

	void Update () {
		
	}
}
