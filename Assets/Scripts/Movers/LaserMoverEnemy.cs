using UnityEngine;
using System.Collections;

public class LaserMoverEnemy : MonoBehaviour {
	
	public Rigidbody rb;
	public float laserspeed;
	
	// Use this for initialization
	void Start () 
	{
		rb.velocity = transform.forward * -laserspeed;
	}
}
