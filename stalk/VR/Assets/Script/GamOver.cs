using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamOver : MonoBehaviour {

    [SerializeField] int index;
	Animator anim;
	public GameObject doo;
	public GameObject dor;
    // Use this for initialization
    void Start()
    {
		anim = GetComponent<Animator> ();
		dor.SetActive (false);
		doo.SetActive (true);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider c)
    {
		if (Keys.keycount == 0 && c.gameObject.tag == "Player") {
			anim.SetBool ("open", true);
			anim.SetTrigger ("opens");
			dor.SetActive (true);
			doo.SetActive (false);
		}
    }
    public void LoadScene(int SceneIndex)
    {

        SceneManager.LoadScene(SceneIndex);
    }
}
