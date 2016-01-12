using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WaveController : MonoBehaviour {

	public Transform spawnPoint;
	public GameObject enemyPrefab;
	public int enemyDist;
	public int columns;
	public int rows;

	private List<GameObject> enemies = new List<GameObject>();

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.F1))
			InstantiateWave ();

		if (Input.GetKeyDown (KeyCode.F2))
			Inactvate ();

	}

	void InstantiateWave ()
	{
		for (int column = 0; column < columns; ++column) {
			for (int row = 0; row < rows; ++row) {
				float newX = column * enemyDist + spawnPoint.position.x;
				float newZ = row * -enemyDist + spawnPoint.position.z;
				Vector3 newPosition = new Vector3 (newX, spawnPoint.position.y, newZ);

				var newEnemy = Object.Instantiate (enemyPrefab, newPosition, spawnPoint.transform.rotation) as GameObject;
				newEnemy.transform.SetParent (transform);
				enemies.Add(newEnemy);
			}
		}
	}

	void Inactvate ()
	{
		foreach (GameObject enemy in enemies)
			enemy.SetActive (false);
	}
}
