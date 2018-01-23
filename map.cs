using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class map : MonoBehaviour {
	private GameObject TimerCanvas, MapCanvas;

	void Awake(){
		TimerCanvas = GameObject.Find ("TimerCanvas");
		MapCanvas = GameObject.Find ("MapCanvas");
	}

	void Start(){

		MapCanvas.SetActive (true);
		TimerCanvas.SetActive (false);
	}

	IEnumerator fadeOut(GameObject obj, float speed){
		float increment;
		CanvasGroup cv = obj.GetComponent<CanvasGroup> ();
		while (cv.alpha>0){
			increment = speed * Time.deltaTime;
			if (cv.alpha - increment < 0)
				cv.alpha = 0;
			else
				cv.alpha -= speed * Time.deltaTime;
			yield return null;

		}
		obj.SetActive (false);
		TimerCanvas.SetActive (true);
	}


	public void switching(){
		StartCoroutine (fadeOut (MapCanvas,4.0f));

	}
	}

