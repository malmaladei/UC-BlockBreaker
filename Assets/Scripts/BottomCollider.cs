﻿using UnityEngine;
using System.Collections;

public class BottomCollider : MonoBehaviour {
	
	public LevelManager levelManager;
	
	void OnTriggerEnter2D (Collider2D trigger) {
		levelManager.LoadLevel("Lose");
		}
		
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
}
