using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

	public int speed;

	// na starcie dostaje velocity o wartości speed
	void Start () 
	{
		GetComponent<Rigidbody> ().velocity = new Vector3 (speed, 0, 0);
	}

	void OnTriggerEnter (Collider other)
	{

		//Jeżeli wykryje trigger o tagu WWall bądź EWall przemieszcza obiekt o 15 na osi z a następnie dostaję 
		//ujemną wartość prędkości którą posiadał
		if (other.tag == "EWall") 
		{
			var position = gameObject.transform.position;
			gameObject.transform.position = new Vector3 (position.x, position.y, position.z - 15);
			var velocity = GetComponent<Rigidbody> ().velocity;
			GetComponent<Rigidbody> ().velocity = new Vector3 (-velocity.x, velocity.y, velocity.z);
		}
		if (other.tag == "WWall") 
		{
			var position = gameObject.transform.position;
			gameObject.transform.position = new Vector3 (position.x, position.y, position.z - 15);
			var velocity = GetComponent<Rigidbody> ().velocity;
			GetComponent<Rigidbody> ().velocity = new Vector3 (-velocity.x, velocity.y, velocity.z);
		}
	}

}
