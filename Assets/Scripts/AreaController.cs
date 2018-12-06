using UnityEngine;
using System.Collections;

public class AreaController : MonoBehaviour {
    float volume = 0.05f;
	public GameObject target;
    public AudioClip LightSound;
    public GameObject TriggerObject;
    
	void OnTriggerEnter2D(Collider2D coll)
	{
	    target.SetActive(true);
        AudioSource.PlayClipAtPoint(LightSound, transform.position, volume);
	}
	void OnTriggerExit2D(Collider2D coll)
	{
	    target.SetActive(false);
        AudioSource.PlayClipAtPoint(LightSound, transform.position, volume);
	}
	
	void Start () {
        target.SetActive(false);
	}
	
	void Update () {
		
	}
}
