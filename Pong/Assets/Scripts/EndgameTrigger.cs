using UnityEngine;
using System.Collections;

public class EndgameTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter (Collision col)
	{
<<<<<<< HEAD
		GameObject.Find ("Sphere").transform.position = new Vector3 (0, 0, 0); 
	}

	

=======

			GameObject.Find ("Sphere").transform.position = new Vector3 (0, 0, 0);
	}
>>>>>>> ae9cfa8e8da91dd603a5f34023923b0db2d0db84
}
