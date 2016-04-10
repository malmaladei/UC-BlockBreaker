using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {
	public BouncyBrick bouncyBrick;
	
	private Vector3 bouncyBrickToBallVector;
	private bool ballOff;
	
	// Use this for initialization
	void Start () {
		bouncyBrickToBallVector = this.transform.position - bouncyBrick.transform.position;
		}
	
	// Update is called once per frame
	void Update () {
		if (ballOff != true) {
			this.transform.position = bouncyBrick.transform.position + bouncyBrickToBallVector;
			
			if (Input.GetMouseButton(0)) {
				this.rigidbody2D.velocity = new Vector2(2f,10f);
				ballOff = true;
				Debug.Log ("Mouse button clicked");
				}
			}
		}
	}
