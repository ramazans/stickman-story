using UnityEngine;
using System.Collections;

public class ZeminController : MonoBehaviour {

    float volume = 0.2f;
    public AudioClip LightSound;

    void OnTriggerEnter2D(Collider2D coll)
    {
        AudioSource.PlayClipAtPoint(LightSound, transform.position, volume);
    }
    void OnTriggerExit2D(Collider2D coll)
    {
    }
}
