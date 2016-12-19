using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GameManager_LV1 : MonoBehaviour {


	public int numBalls =5;
	public Object balls;
	public GameObject ballPrefabs;

	public GameObject panelInstructions; 

	public List<Vector3> listPosition;
	public Vector3 firstLayer;
	public Vector3 secondLayer;
	public int tempNum;
	public int numberOfBalls=8;

	// Use this for initialization
	void Start () {

		firstLayer = new Vector3 (-7.32f,-1.65f,-0.15f);
		secondLayer = new Vector3 (-8.07f,-3.07f,-0.15f);
		listPosition = new List<Vector3> ();

		for(int x=0; x<8; x++){
			listPosition.Add ( new Vector3(firstLayer.x+(2.2f*x), firstLayer.y, firstLayer.z));
			listPosition.Add ( new Vector3(secondLayer.x+(2.2f*x), secondLayer.y, secondLayer.z));
		}








		panelInstructions.SetActive (true);
	
		SpawnBalls ();
	}

	void SpawnBalls ()
	{
		//GameObject balls = Instantiate (Resources.Load ("Balls")) as GameObject;
		/*--

		for (int x = 0; x < listPosition.Count; x++) {
			ballPrefabs = Instantiate (balls, listPosition[x],Quaternion.Euler(-90, 18, 0)) as GameObject;	
		}

		--*/
		for(int x=0; x<numberOfBalls; x++){
			tempNum = Random.Range (0, listPosition.Count);
			ballPrefabs = Instantiate (balls, listPosition[tempNum],Quaternion.Euler(-90, 18, 0)) as GameObject;	
			listPosition.RemoveAt (tempNum);
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
