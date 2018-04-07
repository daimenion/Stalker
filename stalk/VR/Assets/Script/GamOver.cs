using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GamOver : MonoBehaviour {

    [SerializeField] int index;
	Animator anim;
	public GameObject doo;
	public GameObject dor;
	[SerializeField] private Text customText;
    // Use this for initialization
    void Start()
    {
		anim = GetComponent<Animator> ();

    }

    // Update is called once per frame
    void Update()
    {
		if (Keys.keycount == 4 )
			customText.enabled = true;
		else
			customText.enabled = false;
    }

    void OnTriggerEnter(Collider c)
    {

		if (Keys.keycount == 4 && c.gameObject.tag == "Player") {
			anim.SetBool ("open", true);
			anim.SetTrigger ("opens");
		}
    }
    public void LoadScene(int SceneIndex)
    {

        SceneManager.LoadScene(SceneIndex);
    }

	
}
