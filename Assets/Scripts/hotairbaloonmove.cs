using UnityEngine;
using System.Collections;

public class hotairbaloonmove : MonoBehaviour {


	public GameObject hotAirBalloon;

	float curveX = 5.0f;
	float curveY = 1.8f;
	float alongTheX = 0.5f;
	float alongTheY = 1.5f;
	float length; 

	float curveSpeed = 2;


	// Use this for initialization
	void Start () {

		transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);

	}
	
	// Update is called once per frame
	void Update () {


	
		length += Time.deltaTime * curveSpeed;
		float x = curveX * Mathf.Sin (alongTheX * length);
		float y = Mathf.Abs (curveY * Mathf.Cos (alongTheY * length));
		transform.localPosition = new Vector3 (x, y, 0);


			
	}
}


