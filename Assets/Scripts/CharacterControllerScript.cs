using UnityEngine;

namespace Assets.Scripts
{
    public class CharacterControllerScript : MonoBehaviour {

        // Use this for initialization
        public float maxSpeed = 100f;
        bool facingRight = true;

        Animator anim;

        //for grounded
        public bool grounded = true;
        public bool slient = false;
        public Transform groundCheck;
        float groundRadius = 0.2f;
        public LayerMask WhatIsGround;
        //for grounded
        public float jumpForce = 0.2f;

        void Start () {
            anim = GetComponent<Animator> ();

        }
	
        // Update is called once per frame
        void FixedUpdate () {
			if (anim.GetBool ("Dead") == false) {
				grounded = Physics2D.OverlapCircle (groundCheck.position, groundRadius, WhatIsGround);
				anim.SetBool ("Ground", grounded);

				anim.SetFloat ("vSpeed", GetComponent<Rigidbody2D> ().velocity.y);


				float move = Input.GetAxis ("Horizontal");
				anim.SetFloat ("Speed", Mathf.Abs (move));
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (move * maxSpeed, GetComponent<Rigidbody2D> ().velocity.y);
				if (move > 0 && !facingRight) {
					Flip ();
				} else if (move < 0 && facingRight) {
					Flip ();
				}
			}
        }

        void Update()
        {

            if (grounded && Input.GetKeyDown (KeyCode.Space)) {
                anim.SetBool ("Ground", false);
                GetComponent<Rigidbody2D> ().AddForce (new Vector2 (0, jumpForce));
            }
            else if (Input.GetKey(KeyCode.LeftControl) && Input.GetKey(KeyCode.RightArrow))
            {
                anim.SetBool("Slient", true);
                maxSpeed = 2f;
            }
            else if (Input.GetKey(KeyCode.LeftControl) && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)) || Input.GetKey(KeyCode.LeftShift) && (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow)))
            {
                anim.SetBool("Slient", true);
                maxSpeed = 2f;
            }
            else if (!Input.GetKey(KeyCode.LeftControl))
            {
                anim.SetBool("Slient", false);
                maxSpeed = 5f;
            }
        }
        void Flip()
        {
            facingRight = !facingRight;
            Vector3 theScala = transform.localScale;
            theScala.x *= -1;
            transform.localScale = theScala;
        }
    }
}
