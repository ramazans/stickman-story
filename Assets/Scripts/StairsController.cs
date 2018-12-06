using UnityEngine;
using System.Collections;

public class StairsController : MonoBehaviour {

	bool Merdiven = false;
	Animator anim;
	void OnCollisionEnter2D(Collision2D cc)
	{
		if (cc.gameObject.tag == "Merdiven") {
			GetComponent<Animator> ().SetBool ("Merdiven", true);
		}
	}
	void OnCollisionExit2D(Collision2D cc){
		if (cc.gameObject.tag == "Merdiven") {
			GetComponent<Animator> ().SetBool ("Merdiven", false);
		}
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
