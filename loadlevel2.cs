using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class loadlevel2 : MonoBehaviour {

	void Start () {

		StartCoroutine (MyMethod());

	}

	IEnumerator MyMethod(){

		yield return new WaitForSeconds (3);
		SceneManager.LoadScene ("2");
	}
}
