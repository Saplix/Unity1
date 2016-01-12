using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Player")
		{
			return;
		}
		if (other.tag == "BackGround") 
		{
			return;
		}
		if (other.tag == "NWall")
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
