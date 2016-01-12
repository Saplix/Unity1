using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Level2toLevel1 : MonoBehaviour {

	public GameObject enemyPrefab;
	
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "PlayerLaser") 
		{
			var oldVelocity = gameObject.GetComponent<Rigidbody>().velocity;
			Destroy (gameObject);

			GameObject enemy = Instantiate(enemyPrefab, gameObject.transform.position, gameObject.transform.rotation) as GameObject;
			enemy.GetComponent<Mover>().speed *= (int)Mathf.Sign(oldVelocity.x);
		}
			
	}
			
}
