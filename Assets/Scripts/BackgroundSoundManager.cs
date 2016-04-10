
using UnityEngine;
using System.Collections;

public class BackgroundSoundManager : MonoBehaviour {

	public static int BackgroundSoundInstances = 0;
	
	void Start () {
		if ( BackgroundSoundInstances == 0 ) {
			GameObject.DontDestroyOnLoad(gameObject);
			BackgroundSoundInstances = 0;
		}
		else {
			GameObject.DestroyImmediate(gameObject);
			BackgroundSoundInstances = 0;
		}
			
		BackgroundSoundInstances++;
		}
	
	// Update is called once per frame
	void Update () {
	
		}
	}
