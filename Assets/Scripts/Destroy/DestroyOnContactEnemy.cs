using UnityEngine;
using System.Collections;

public class DestroyOnContactEnemy : MonoBehaviour {
	
	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Enemy")
		{
			return;
		}
		if (other.tag == "EnemyLaser")
		{
			return;
		}
		if (other.tag == "BackGround")
		{
			return;
		}
		if (other.tag == "SWall")
		{
			return;
		}
		if (other.tag == "Upgrade") 
		{
			return;
		}
		Destroy(other.gameObject);
		Destroy(this.gameObject);
	}
}
