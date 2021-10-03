using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Health : MonoBehaviour
{

    // Start is called before the first frame update
    AudioSource source1;
    private void Start()
    {
        source1 = GameObject.FindGameObjectWithTag("Hit").GetComponent<AudioSource>();
        source1.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Player")
        {
            source1 = GameObject.FindGameObjectWithTag("Hit").GetComponent<AudioSource>();
            source1.Play();
            HealthBar.Health = HealthBar.Health - 25f;
            if (HealthBar.Health == 0)
            {
                SceneManager.LoadScene("GameOver");
            }
        }
        
    }
}
