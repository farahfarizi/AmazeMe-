using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadlevel1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		StartCoroutine (MyMethod());

	}

	IEnumerator MyMethod(){

		yield return new WaitForSeconds (3);
		SceneManager.LoadScene ("1");
	}

}
