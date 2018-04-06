using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour {
	public GameObject doo;
	public GameObject dor;
	// Use this for initialization
	void Start () {
		dor.SetActive (false);
		doo.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter (Collider c)
	{
		if (c.gameObject.tag == "opened") {
			dor.SetActive (true);
			doo.SetActive (false);
		}
	}

}
