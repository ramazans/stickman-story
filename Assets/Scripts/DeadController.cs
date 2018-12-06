using UnityEngine;
using System.Collections;
//using UnityEditor;

public class DeadController : MonoBehaviour
{
    
    public float vulume = 0.05f;
    public int lives = 3;
    public Transform respawn1;
    public Transform respawn2;
    public Transform respawn3;
    public Transform respawn4;
    public AudioClip CharacterDeadSound;
    public GameObject DeadSoundEffect;
    public GameObject life0;
    public GameObject life1;
    public GameObject life2;
    public GameObject life3;
    public GameObject oldun;
	bool Dead = false;
    Animator anim;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (lives > 0) //öldüğünde buradan başla
        {
            switch (other.gameObject.tag)
            {
                case "Respawn 1":
                {
                    AudioSource.PlayClipAtPoint(CharacterDeadSound, transform.position,vulume);
                    transform.position = respawn1.position;
                    lives -= 1;
                    break;
                }
                case "Respawn 2":
                {
                    AudioSource.PlayClipAtPoint(CharacterDeadSound, transform.position,vulume);
                    transform.position = respawn2.position;
                    lives -= 1;
                    break;
                }
                case "Respawn 3":
                {
                    AudioSource.PlayClipAtPoint(CharacterDeadSound, transform.position,vulume);
                    transform.position = respawn3.position;
                    lives -= 1;
                    break;
                }
                case "Respawn 4":
                {
                    AudioSource.PlayClipAtPoint(CharacterDeadSound, transform.position,vulume);
                    transform.position = respawn4.position;
                    lives -= 1;
                    break;
                }
                default:
                {
                    break;
                }
            }

            switch (lives)
            {
                case 0:
                    {
                        life0.SetActive(true);
                        life1.SetActive(false);
                        life2.SetActive(false);
                        life3.SetActive(false);
                        oldun.SetActive(false);
                        GetComponent<Animator>().SetInteger("Lives", 0);
                        break;
                    }
                case 1:
                    {
                        life0.SetActive(false);
                        life1.SetActive(true);
                        life2.SetActive(false);
                        life3.SetActive(false);
                        oldun.SetActive(false);
                        GetComponent<Animator>().SetInteger("Lives", 1);
                        break;
                    }
                case 2:
                    {
                        life0.SetActive(false);
                        life1.SetActive(false);
                        life2.SetActive(true);
                        life3.SetActive(false);
                        oldun.SetActive(false);
                        GetComponent<Animator>().SetInteger("Lives", 2);
                        break;
                    }
                case 3:
                    {
                        life0.SetActive(false);
                        life1.SetActive(false);
                        life2.SetActive(false);
                        life3.SetActive(true);
                        oldun.SetActive(false);
                        GetComponent<Animator>().SetInteger("Lives", 3);
                        break;
                    }
                default:
                    {
                        
                        break;
                    }
            }
        }
        else
        {
            AudioSource.PlayClipAtPoint(CharacterDeadSound, transform.position,vulume);
            GetComponent<Animator>().SetBool("Dead", true);
            life0.SetActive(false);
            life1.SetActive(false);
            life2.SetActive(false);
            life3.SetActive(false);
            oldun.SetActive(true);
        }
    }

    void Start()
    {
        oldun.SetActive(false);
        life0.SetActive(false);
        life1.SetActive(false);
        life2.SetActive(false);
        life3.SetActive(true);
    }


}
