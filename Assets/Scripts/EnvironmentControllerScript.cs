using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvironmentControllerScript : MonoBehaviour {

	public GameObject startPlatformLocation;
	public GameObject startPlatformPrefab;
	public GameObject playerPrefab;
	public GameObject playerSpawnLocation;
	
	// Use this for initialization
	void Start () {
		Instantiate(startPlatformPrefab, startPlatformLocation.transform.position, Quaternion.identity);
		Instantiate(playerPrefab, playerSpawnLocation.transform.position, Quaternion.identity);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
