using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestTrigger : MonoBehaviour
{
    //ref to the player's animator
    public Animator anim;
    public GameObject final;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        final.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("isOpen", true);
            final.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {

    }
    // Start is called before the first frame update

}
