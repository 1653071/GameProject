using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GateWin : MonoBehaviour
{
    // Start is called before the first frame update
    public int KeyGateCount = 3;
    private Animator animator;
    AudioSource source1;
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
                SceneManager.LoadScene("GameWin");

            }

        }
    }


}
