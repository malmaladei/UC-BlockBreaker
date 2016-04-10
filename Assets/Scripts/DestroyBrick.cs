using UnityEngine;
using System.Collections;

public class DestroyBrick : MonoBehaviour {

	void OnCollisionEnter2D (Collision2D coll) {
		Destroy (this.gameObject);
	}
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
