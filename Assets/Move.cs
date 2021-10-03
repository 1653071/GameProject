using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    private Animator Anim;
    public float speed;
    public float turnSpeed;
   
    public float range;
    private AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        Anim = gameObject.GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
        audio.Stop();
    }
    void Step()
    {

    }
    
    // Update is called once per frame
    void Movement()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed  * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed *Time.deltaTime;
        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    
    }
        void Update()
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.UpArrow))

        {
            Anim.SetBool("isWalking", true);
            Movement();
            audio.Play();
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            Anim.SetBool("isWalking", false);
            audio.Stop();
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            Anim.SetBool("isSprint", true);
        }

        else if (Input.GetKeyUp(KeyCode.E))
        {
            Anim.SetBool("isSprint", false);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Anim.SetBool("isBackward", true);
        }

        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            Anim.SetBool("isBackward", false);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {

            transform.Rotate(Vector3.up, -speed * Time.deltaTime);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {

            transform.Rotate(Vector3.up, speed * Time.deltaTime);

        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {

            Anim.SetBool("isJump", true);

        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {

            Anim.SetBool("isJump", false);

        }







    }
}
