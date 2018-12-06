using UnityEngine;
using System.Collections;

public class DoorOpen : MonoBehaviour {

    public GameObject target;
    public Animator anim;
    void OnTriggerEnter2D(Collider2D coll)
    {
        //target.AddComponent<Animation>().Play();
        anim.SetBool("Door",true);
    }
    void OnTriggerExit2D(Collider2D coll)
    {
        //target.AddComponent<Animation>().Stop();
        anim.SetBool("Door", false);
    }

    void Start()
    {
        //target.AddComponent<Animator>();
        anim = target.GetComponent<Animator>();
    }

    void Update()
    {

    }
}
