using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class AreaSensor : MonoBehaviour 
{
	public GameObject prefab;
	public Text shotsTakenText;
	int shotsTaken = 0;
	int numObjs = 0;
	
	//GameManager gm;
	
	void Start()
	{
		//gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<GameManager> ();
		Instantiate (prefab, transform.position + new Vector3 (0, 1, 0), Quaternion.identity);
	}

	void OnTriggerExit( Collider coll )
	{
		if (coll.tag == "Puck") 
		{
			//gm.TookShot();
			shotsTaken++;
			shotsTakenText.text = "Shots Taken: " + shotsTaken;
			numObjs --;
			if( numObjs <= 0)
				Instantiate (prefab, transform.position + new Vector3 (0, 1, 0), Quaternion.identity);
		}
	}

	void OnTriggerEnter( Collider coll )
	{
		if (coll.tag == "Puck")
			numObjs ++;
	}
}
