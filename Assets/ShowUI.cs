using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowUI : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject text;
    void Start()
    {
        
   
        StartCoroutine("WaitForSec");
    }
   
    // Update is called once per frame
    
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(3);
        Destroy(text);
    }
}
