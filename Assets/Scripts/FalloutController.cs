using UnityEngine;
using System.Collections;

public class FalloutController : MonoBehaviour
{

    public int lives = 5;
    public Transform respawn;

	//
	void Start () {
	
	}
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "GameOver") //öldüğünde buradan başla
        {
            transform.position = respawn.position;
            lives -= 1;
        }
    }
}
