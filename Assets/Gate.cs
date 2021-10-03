using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Gate : MonoBehaviour
{
    // Start is called before the first frame update
    public int KeyGateCount =3;
    private Animator animator;
    AudioSource source1;
    public GameObject text;
    void Start()
    {
        source1 = GameObject.FindGameObjectWithTag("OpenDoor").GetComponent<AudioSource>();
        source1.Stop();
        animator = gameObject.GetComponent<Animator>();
        animator.SetBool("isOpen", false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (GameVariable.keycount == 3)
            {
                source1.Play();
                KeyGateCount = KeyGateCount - GameVariable.keycount;
                animator.SetBool("isOpen", true);
                GameVariable.keycount = 0;
                StartCoroutine("WaitForSec1");
            }
            else 
            {
                text.SetActive(true);
                StartCoroutine("WaitForSec");
            }

        }
    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        text.SetActive(false);
    }
    IEnumerator WaitForSec1()
    {
        yield return new WaitForSeconds(1);
        
    }


}
