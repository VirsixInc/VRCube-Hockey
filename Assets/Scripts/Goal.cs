using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Goal : MonoBehaviour 
{
	//GameManager gm;
	int score = 0;
	public Text scoreText;

	void Start()
	{
		//gm = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<GameManager> ();
	}

	void OnTriggerEnter( Collider coll )
	{
		if (coll.tag == "Puck") 
		{
			score += 1;
			scoreText.text = "Score: " + score;
		}
			//gm.AddScore (1);
	}
}
