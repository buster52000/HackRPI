﻿using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find ("Sphere").transform.position.y > this.transform.position.y)
<<<<<<< HEAD
			transform.position += new Vector3 (0, 0.15f, 0);
		if (GameObject.Find ("Sphere").transform.position.y < this.transform.position.y)
			transform.position -= new Vector3 (0, 0.15f, 0);
=======
			transform.position += new Vector3 (0, 0.2f, 0);
		if (GameObject.Find ("Sphere").transform.position.y < this.transform.position.y)
			transform.position -= new Vector3 (0, 0.2f, 0);
>>>>>>> ae9cfa8e8da91dd603a5f34023923b0db2d0db84

	}
}
