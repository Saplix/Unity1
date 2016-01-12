using UnityEngine;
using System.Collections;

public class UpgradeController : MonoBehaviour 
{

	public GameObject fireRateUp;
	public GameObject doubleShot;
	public GameObject tripleShot;

	private float dropChance;
	private float minChance = 0;
	private float maxChance = 100;

	void Start()
	{
		dropChance = Random.Range (minChance, maxChance);
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag == "PlayerLaser")
		{
			if (dropChance > 85) 
			{
				Instantiate (fireRateUp, transform.position, transform.rotation);
			}
			if (dropChance > 90) 
			{
				Instantiate (doubleShot, transform.position, transform.rotation);
			}
			if (dropChance > 95) 
			{
				Instantiate (tripleShot, transform.position, transform.rotation);
			}

		}

	}


}
