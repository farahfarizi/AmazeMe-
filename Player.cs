using UnityEngine;

using System.Diagnostics;
using UnityEngine.SceneManagement;
using System.Collections;


public class Player : MonoBehaviour {
	
	bool keyCheck = false;
	int scene;
	public float score;
	public float highscore;
	public float seconds, minutes;



	void Start () {

	
		scene = SceneManager.GetActiveScene().buildIndex;
		PlayerPrefs.GetFloat ("highscorePref");
		highscore = PlayerPrefs.GetFloat ("highscorePref");

		/*PlayerPrefs.GetFloat ("scorePref");
		score = PlayerPrefs.GetFloat ("scorePref");*/
	}

	void OnTriggerEnter(Collider other){

		if(other.gameObject.tag == "Trap")
		{
			print ("Dies");
		
			SceneManager.LoadScene (scene,LoadSceneMode.Single);
		}

		if (other.gameObject.tag == "key") {
			print ("Key Obtained");
			keyCheck = true;
			Destroy (other.gameObject);


		}

		if (other.gameObject.tag == "Finish") {
			print ("hitting the door");
			if(keyCheck==true){
			print ("Door opened");


			Destroy (other.gameObject);
				SceneManager.LoadScene ("endScene");
				print ("HS = "+highscore);
				if(score<highscore && score>1){
					highscore = score;

					PlayerPrefs.SetFloat ("highscorePref",highscore);
					PlayerPrefs.SetFloat ("scorePref",score);
					print ("High score = "+highscore);

				}

			}
		}



	}




	void Update (){

		minutes = (int)(Time.timeSinceLevelLoad / 60f);
		seconds = (int)(Time.timeSinceLevelLoad % 60f);
		score = minutes*100 + seconds;
		PlayerPrefs.SetFloat ("highscorePref",highscore);
		PlayerPrefs.SetFloat ("scorePref",score);

	}


}
