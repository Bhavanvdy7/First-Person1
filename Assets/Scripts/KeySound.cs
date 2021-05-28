using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeySound : MonoBehaviour
{
    public AudioClip keyClip;
    AudioSource keySound;
    public float volume;
    bool played;

    private void Start()
    {
        keySound = GetComponent<AudioSource>();
        played = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
            if (played == false)
            {
                {
                    keySound.PlayOneShot(keyClip, volume);
                    played = true;
                }
            }
    }
    // Start is called before the first frame update

}
