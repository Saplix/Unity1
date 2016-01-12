using UnityEngine;
using System.Collections;

public class UpgradeMover : MonoBehaviour 
{

	public Rigidbody rb;
	public float speed;
	
	// Use this for initialization
	void Start () 
	{
		rb.velocity = transform.forward * speed;
	}
}
