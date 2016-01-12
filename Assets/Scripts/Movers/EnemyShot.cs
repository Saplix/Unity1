using UnityEngine;
using System.Collections;

public class EnemyShot : MonoBehaviour {

	public GameObject shot;
	public Transform shotSpawn;
	private float fireRate;
	private float nextFire;
	public float minFireRate;
	public float maxFirerate;

	void Start()
	{
		fireRate = Random.Range (minFireRate, maxFirerate);
		nextFire = Time.time + fireRate;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Time.time > nextFire) 
		{
			fireRate = Random.Range(minFireRate,maxFirerate);
			nextFire = Time.time + fireRate;
			Instantiate (shot, shotSpawn.position, shotSpawn.rotation);
		}
	}
}
