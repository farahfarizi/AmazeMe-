using UnityEngine;
using System.Collections;

public class Trap : MonoBehaviour {

	public float delayTime;
	// Use this for initialization
	void Start () {
		StartCoroutine (Go ());
	}
	
	// Update is called once per frame
	IEnumerator Go(){
		while(true){
			GetComponent<Animation>().Play ();
			//untuk default animation
			yield return new WaitForSeconds(3f);
		}
	
	}
}
