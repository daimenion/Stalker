using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour {

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }


 
    void Update () {
	}
    private void OnTriggerEnter(Collider other)
    {
        anim.SetTrigger("open");
    }

    private void OnTriggerExit(Collider other)
    {
        
    }


}
