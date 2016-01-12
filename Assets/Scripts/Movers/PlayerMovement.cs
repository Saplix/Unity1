using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float playerSpeed;
	private BlockPlayerMovement isBlocked;
	public enum BlockPlayerMovement
	{
		BlockRight,
		BlockLeft,
		NoBlock,
	}

	void Start()
	{
		isBlocked = BlockPlayerMovement.NoBlock;
	}

	// Update is called once per frame
	void Update () 
	{
//		var mainCamera = Camera.main;
//		
//		Vector3 upperRight = new Vector3 (Screen.width, Screen.height, 0.0f);
//		Vector3 worldPos = mainCamera.ScreenToWorldPoint (upperRight);
//		Debug.LogFormat ("World position: {0}", worldPos);
//
//		isBlocked = (transform.position.x > worldPos.x) ? BlockPlayerMovement.BlockRight : BlockPlayerMovement.NoBlock;

		float HorizontalMovement = Input.GetAxis ("Horizontal");
		if (isBlocked == BlockPlayerMovement.BlockLeft && HorizontalMovement < 0)
			return;
		if (isBlocked == BlockPlayerMovement.BlockRight && HorizontalMovement > 0)
			return;
		transform.Translate (new Vector3(HorizontalMovement * playerSpeed, 0.0f, 0.0f));




//		if (blockedMovement == BlockMovement.BLOCK_DOWN && verticalMovement < 0)
//			return;
//		if (blockedMovement == BlockMovement.BLOCK_UP && verticalMovement > 0)
//			return;
	}
//
	void OnTriggerEnter(Collider collider)
	{
		 if (collider.gameObject.tag == "EWall") 
			isBlocked = BlockPlayerMovement.BlockRight;
			else if (collider.gameObject.tag == "WWall")
			isBlocked = BlockPlayerMovement.BlockLeft;
	}

	void OnTriggerExit (Collider collider)
	{
		if (collider.gameObject.tag == "EWall" || collider.gameObject.tag == "WWall")
			isBlocked = BlockPlayerMovement.NoBlock;
	}
}
