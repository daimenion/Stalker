using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class seePlayer : MonoBehaviour {
	public Light spotLight;
	public float viewDistance;
	public LayerMask viewMask;
	float viewAngle;
	Transform target;
	public Animator m_Animator;
	bool detected;

	public float speed = 5f;
	// Use this for initialization
	void Start () {
		target = GameObject.FindGameObjectWithTag ("Player").transform;
		viewAngle = spotLight.spotAngle;
		m_Animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (CanSeeTarget ()) {
			transform.LookAt (target.position);
			transform.Rotate (new Vector3 (0, 0, 0), Space.Self);
			Vector3 dir = target.position - transform.position;
			float distancethis = speed * Time.deltaTime;
			transform.Translate (dir.normalized * distancethis, Space.World);
			spotLight.color = Color.red;
			m_Animator.SetBool ("detected", true);

				
		} else {
			spotLight.color = Color.white;
			transform.Rotate (0,50*Time.deltaTime,0);
			m_Animator.SetBool ("detected", false);
		}
	}
	bool CanSeeTarget(){
		if (Vector3.Distance (transform.position, target.position) < viewDistance) {
			Vector3 dirToTarget = (target.position - transform.position).normalized;
			float angle = Vector3.Angle (transform.forward, dirToTarget);
			if (angle < viewAngle/2f) {
				if (!Physics.Linecast (transform.position, target.position, viewMask))
					return true;
			}
		}
		return false;
	}
	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag=="Player")
			LoadScene(3);
			}
	public void LoadScene(int SceneIndex)
	{

		SceneManager.LoadScene(SceneIndex);
	}
}
