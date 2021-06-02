using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoombieLook : MonoBehaviour
{
    public GameObject focusedObject;
    public Animator zombieAnimation;
    public GameObject zombie;
    public bool died;

    // Start is called before the first frame update
    void FixedUpdate()
    {
        Ray ray = new Ray(transform.position, transform.forward);

        //RaycastHit

            if (zombie != null )
        {
                focusedObject.GetComponent<ZombieLookAtPlayer>().speed = 1;
                zombieAnimation.SetBool("isRunning", false);
                zombie = null;
        }
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            focusedObject = hit.collider.gameObject;
            if (focusedObject.CompareTag("Zombie"))
            {
                    zombieAnimation = focusedObject.GetComponent<Animator>();
                if (focusedObject.GetComponent<Target>().health == 0f)
                {
                    focusedObject.GetComponent<ZombieLookAtPlayer>().speed = 0f;
                    zombieAnimation.SetBool("isDie", true);
                    died = true;
                }
                else if (died == false)
                {
                    focusedObject.GetComponent<ZombieLookAtPlayer>().speed = 3;
                    zombieAnimation.SetBool("isRunning", true);
                    zombie = focusedObject;
                }

            }
        }

    }

}
