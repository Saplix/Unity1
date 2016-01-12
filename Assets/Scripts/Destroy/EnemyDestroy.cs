using UnityEngine;
using System.Collections;

public class EnemyDestroy : MonoBehaviour {

	public GameObject explosion;
	public int scoreValue;
	private GameController gameController;

	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("GameController");
		if (gameControllerObject != null) 
		{
			gameController = gameControllerObject.GetComponent <GameController>();
		}
		if (gameController == null)
		{
			Debug.Log ("cant find game controller");
		}
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "BackGround") 
		{
			return;
		}
		if (other.tag == "EWall") 
		{
			return;
		}

		if (other.tag == "WWall")
		{
			return;
		}
		if (other.tag == "EnemyLaser")
		{
			return;
		}

		if (other.tag != "Enemy") 
		{
			Instantiate (explosion, transform.position, transform.rotation);
			gameController.AddScore (scoreValue);
			//AudioSource=Play
		}
	}

}
