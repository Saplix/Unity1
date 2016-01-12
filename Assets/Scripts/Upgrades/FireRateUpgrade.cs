using UnityEngine;
using System.Collections;

public class FireRateUpgrade : MonoBehaviour 
{
	private float upgradeLifeTime;

	void OnTriggerEnter(Collider other)
	{
		upgradeLifeTime = 0.2f;
		Debug.Log (other.name);
		if (other.name == "Player")
		{
			Debug.Log (other.name);
			other.GetComponent<LaserShoot> ().fireRate = 0.4f;
			Destroy (gameObject, upgradeLifeTime);
		}
	}
}