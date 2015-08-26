using UnityEngine;
using System.Collections;

public class AddForce : MonoBehaviour {

	public int horiSpeed;
	private Rigidbody rb;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		rb.AddForce (horiSpeed, Random.Range(-100,100) , 0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
