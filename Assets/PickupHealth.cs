using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupHealth : MonoBehaviour
{
    // Start is called before the first frame update
    AudioSource audio;
    private void OnTriggerEnter(Collider other)
    {
        
        if(HealthBar.Health < 100f)
        {
            HealthBar.Health += 25f;
            audio.Play();
            Destroy(this.gameObject);
        }
        else
        {
            
            HealthBar.Health += 0f;
            audio.Play();
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        audio = GameObject.FindGameObjectWithTag("Pickup").GetComponent<AudioSource>();
        audio.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
