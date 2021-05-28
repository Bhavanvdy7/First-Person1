using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    public int counter;
    public Animator anim;
    public AudioClip doorClip;
    AudioSource doorSound;
    public float volume;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        doorSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        counter = GameObject.FindGameObjectsWithTag("Pickup").Length;
        if (counter == 0)
        {
            anim.SetBool("isOpen", true);
            doorSound.PlayOneShot(doorClip, volume);
        }
    }
}
