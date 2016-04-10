using UnityEngine;
using System.Collections;

public class BouncyBrick : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
	
		}

	// Update is called once per frame
	void Update () {
		Vector3 BouncyBrickPos = new Vector3 (8f, this.transform.position.y, this.transform.position.z);
		
		float mousePositionGU = Input.mousePosition.x / Screen.width * 16;
		BouncyBrickPos.x = Mathf.Clamp(mousePositionGU, 0.5f, 15.5f);
		
		this.transform.position = BouncyBrickPos;
		}
	}
