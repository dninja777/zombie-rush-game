using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour {

	[SerializeField] private float platformSpeed = 1f;
	private float resetPosition = 22.79258f;
	private float newPosition = -107.6f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.left * (platformSpeed * Time.deltaTime));
		if (transform.localPosition.x >= resetPosition)
		{
			Vector3 newPos = new Vector3(newPosition, transform.position.y, transform.position.z);
			transform.position = newPos;
		}
		
	}

	
}
