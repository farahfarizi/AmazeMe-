using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour {


	public Button quitMenu;
	public Button startButton;
	public Button CreditButton;
	/*public Button OkButton;
	public Button lvl1;
	public Button lvl2;
	public Button lvl3;
	public Button lvl4;*/

	void Start(){
		
		quitMenu = quitMenu.GetComponent<Button>();
		CreditButton = CreditButton.GetComponent<Button> ();
		startButton = startButton.GetComponent<Button> ();
		/*OkButton = OkButton.GetComponent<Button> ();
		lvl1 = lvl1.GetComponent<Button> ();
		lvl2 = lvl2.GetComponent<Button> ();
		lvl3 = lvl3.GetComponent<Button> ();
		lvl4 = lvl4.GetComponent<Button> ();*/
	}



	public void startMenu(){


		SceneManager.LoadScene("HowToPlay");
	}

	public void backtoMain(){


		SceneManager.LoadScene("MainMenu");
	}

	public void AboutMenu(){


		SceneManager.LoadScene ("about");
	}

	public void Level1(){
		SceneManager.LoadScene ("m1");



	}

	public void Level2(){


		SceneManager.LoadScene ("m2");
	}

	public void Level3(){


		SceneManager.LoadScene ("m3");
	}
	public void Level4(){


		SceneManager.LoadScene ("m4");
	}


	public void LevelSelect(){
		SceneManager.LoadScene ("LevelSelect");

	}
	public void ExitGame(){


		Application.Quit();
	}
}
