using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    private Rigidbody rigidbody;
    public Text Keytext1;

    AudioSource source1;
    // Start is called before the first frame update
     void Start()
    {
        
        rigidbody = GetComponent<Rigidbody>();
        GameVariable.keycount = 0;
        source1 = GameObject.FindGameObjectWithTag("Pickup").GetComponent<AudioSource>();
        source1.Stop();
    }
    void Update()
    {
       Keytext1.text = GameVariable.keycount.ToString();
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            
            source1.Play();
            //GetComponent<AudioSource>().PlayOneShot(clip, 0.7F);

            GameVariable.keycount += 1;
            
          
            
            
           Destroy(this.gameObject);
                       
           
            


        }
    }


}

