using UnityEngine;
using System.Collections;

public class Collis : MonoBehaviour {

	// Use this for initialization
    Animator anim;

    void OnCollisionEnter2D(Collision2D coll)
    {
        /*if (coll.gameObject.layer == 13) 
        {
            
            //anim.Play("Dead.anim");
            //GetComponent<Animator>().Play("Dead");



			GetComponent<Animator>().SetBool("Die",true);
            anim.SetBool("Die",true);




			//anim.parameters.SetValue("Die",true);
			//Destroy(gameObject);
            //anim.CrossFade("Die", 1);
            
        }*/

        if (coll.gameObject.tag == "level2")
        {
            Application.LoadLevel("Scene2");
        }

        if (coll.gameObject.layer==14)
        {
            GetComponent<Animator>().SetBool("Merdiven", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Merdiven", false);
        }

        if (coll.gameObject.tag == "Havuz")
        {
            GetComponent<Animator>().SetBool("Swimming", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("Swimming", false);
        }
            
    }

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
