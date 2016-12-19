using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public GameObject playGamePanel;
	public GameObject topScorePanel;
	public GameObject creditsPanel;

	public GameObject buttonSound;
	public AudioSource audio; 




	// Use this for initialization
	void Start () {
		//Original sprite before click
		playGamePanel.SetActive (false);
		topScorePanel.SetActive (false);
		creditsPanel.SetActive (false);

		//Grab audio source and play sound
		audio = buttonSound.GetComponent<AudioSource> ();



	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Toggle campaign sprite when clicked
	public void SetPlayGame(){ 
		playGamePanel.SetActive(true);
		topScorePanel.SetActive(false);
		creditsPanel.SetActive(false);
		}

	//Toggle settings sprite when clicked
	public void SetTopScore(){ 
		playGamePanel.SetActive (false);
		topScorePanel.SetActive (true);
		creditsPanel.SetActive (false);
		}

	//Toggle Topscore sprite when clicked
	public void SetCredits(){ 
		playGamePanel.SetActive (false);
		topScorePanel.SetActive (false);
		creditsPanel.SetActive (true);
		}

	//when level 1 button pressed change scene to Level 1 shape
	public void LevelOne (){ 
		Application.LoadLevel ("Level1Shapes"); 
	}

	//when level 1 button pressed change scene to Level 2 alphabet
	public void LevelTwo (){ 
		Application.LoadLevel ("Level2Alphabet"); 
	}

	//when level 1 button pressed change scene to Level 3 numbers
	public void LevelThree (){ 
		Application.LoadLevel ("Level3Numbers"); 
	}


	//Back Button when pressed, loads main menu
	public void BackButton () {
		Application.LoadLevel ("MainMenu");
	}

	//Play audio source when button is pressed
	public void ButtonAudio () {
		audio.Play();

	} 

}
