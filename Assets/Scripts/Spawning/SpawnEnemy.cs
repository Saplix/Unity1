using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {
	// Update is called once per frame

	public Rigidbody enemyprefab1;
	public Transform respawnPosition;

	void respawnEnemy()
	{
		Instantiate(enemyprefab1, respawnPosition.position, respawnPosition.rotation);
	}

	void Update () 
	{
		if (Input.GetKeyUp(KeyCode.F1))
			{
			respawnEnemy();
			}
	}
}
