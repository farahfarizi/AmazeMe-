using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class endScript : MonoBehaviour {

	public Text hs;
	public Text sscore;
	public float hsShow;
	public float sShow;
	void Start () {

		hs = GetComponent<Text>() as Text;
		sscore = GetComponent<Text> () as Text;

		hsShow = PlayerPrefs.GetFloat ("highscorePref");

	

		sShow = PlayerPrefs.GetFloat ("scorePref");

		//sShow = PlayerPrefs.GetFloat ("scorePref");

		/*GameObject go = GameObject.Find ("Player");
		Player player = go.GetComponent<Player>();*/


		sscore.text = ("SCORE :");
		hs.text = ("HIGH SCORE: ");

		//score = PlayerPrefs.GetFloat ("score");
	}


	public void MainMenuLoad(){


		SceneManager.LoadScene ("MainMenu");
	}

}
