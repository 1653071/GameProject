using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Image image;
    float startHealth = 100f;
    public static float Health;
    // Start is called before the first frame update
   
    void Start()
    {
        image = GetComponent<Image>();
        image.fillAmount = 1f;
        Health = startHealth;
    }

    // Update is called once per frame
    void Update()
    {
        image.fillAmount = Health / startHealth;
    }
}
