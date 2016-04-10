using UnityEngine;
using System.Collections;

public class CheckWallsExistence : MonoBehaviour {
	
	public LevelManager levelManager;
	
	// Use this for initialization
	void Start () {
	
		}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("DestroyBrick") == null) {
			levelManager.LoadLevel("Win");
			}
		}
	}
