using UnityEngine;
using System.Collections;

public class SlinderController : MonoBehaviour {
    public GameObject target;
    public Animation anim;
    void OnTriggerEnter2D(Collider2D coll)
    {
        anim.Play();
    }

    private void OnTriggerExit2D(Collider2D coll)
    {
        
    }

    void Start()
    {
        //target.AddComponent<Animator>();
        anim = target.GetComponent<Animation>();
        anim.Stop();
    }

    void Update()
    {

    }
}
