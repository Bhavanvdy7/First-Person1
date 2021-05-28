using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    bool isFlash = false;
    public Animator flashAnim;
    public AudioClip flashClip;
    AudioSource flashSound;
    public float volume;
    // Start is called before the first frame update
    public void Start()
    {
        flashSound = GetComponent<AudioSource>();
    }
    public void OnFlashlight ()
    {
        isFlash = !isFlash;

        if (isFlash)
        {
            flashAnim.SetBool("isOn", true);
            flashSound.PlayOneShot(flashClip, volume);
        }
        else
        {
            flashAnim.SetBool("isOn", false);
            flashSound.PlayOneShot(flashClip, volume);
            isFlash = false;
        }
    }
}
