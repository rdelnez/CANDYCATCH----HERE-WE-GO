using UnityEngine;
using System.Collections;

public class GameManager_LV1 : MonoBehaviour {


	public int numBalls =5;
	public GameObject balls;
	public GameObject ballPrefabs;

	public GameObject panelInstructions; 

	// Use this for initialization
	void Start () {
		panelInstructions.SetActive (true);
	
		SpawnBalls ();
	}

	void SpawnBalls ()
	{
		//GameObject balls = Instantiate (Resources.Load ("Balls")) as GameObject;
		for (int x = 0; x < numBalls; x++) 
		{
			Instantiate (balls, RandomPos (), Quaternion.identity);	
		}
	}


	Vector3 RandomPos()
	{
		int  x,y,z;
		x = UnityEngine.Random.Range (-2, 2);
		y = UnityEngine.Random.Range (-1,1);
		z= UnityEngine.Random.Range (0,0);
		return new Vector3 (x, y, z);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void BackToMainMenu () {
		Application.LoadLevel ("MainMenu");
	}

	//when start button pressed, deactivate panelinstructions
	public void StartGame () {
		panelInstructions.SetActive (false);
	
	}


}
