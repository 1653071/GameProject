using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;
    static Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.position, this.transform.position) < 10)
        {
            Vector3 direction = player.position - this.transform.position;
            direction.y = 0;
            this.transform.rotation = Quaternion.Slerp(this.transform.rotation, Quaternion.LookRotation(direction), 0.1f);
           
            if (direction.magnitude > 3)
            {
                this.transform.Translate(0, 0, 0.005f);
                anim.SetBool("isWalk", true);
                anim.SetBool("isIdle", false);
                
               anim.SetBool("isAttack", false);
            }
            else
            {
                anim.SetBool("isAttack",true );
                anim.SetBool("isWalk", false);
                anim.SetBool("isIdle", false);
            }
        }
        else
        {
            anim.SetBool("isIdle", true);
            anim.SetBool("isAttack", false);
            anim.SetBool("isWalk", false);
        }
    }
}
