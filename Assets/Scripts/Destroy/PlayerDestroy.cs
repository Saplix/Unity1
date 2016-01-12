using UnityEngine;
using System.Collections;

public class PlayerDestroy : MonoBehaviour {

	public GameObject explosion;
	public GUIText gameOverText;

	void Start()
	{
		gameOverText.text = "";
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "EnemyLaser")
		{
			Instantiate (explosion, transform.position, transform.rotation);
			gameOverText.text = "GameOver";
		}

	}
}
