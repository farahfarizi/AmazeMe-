using UnityEngine;
using UnityEngine.UI;
using System.Collections;



public class Timer : MonoBehaviour {
	public Text counterText;
	//public float score;
	public float seconds, minutes;
	// Use this for initialization
	void Start () {
		counterText = GetComponent<Text>() as Text;
		//score = PlayerPrefs.GetFloat ("score");
	}
	
	// Update is called once per frame
	void Update () {
		minutes = (int)(Time.timeSinceLevelLoad / 60f);
		seconds = (int)(Time.timeSinceLevelLoad % 60f);
		counterText.text = minutes.ToString ("00") + ":" + seconds.ToString ("00");
		//score = minutes*100 + seconds;
		//print (score);
	}


}
