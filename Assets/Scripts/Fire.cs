using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem fire;
    public AudioClip fireClip;
    AudioSource fireSound;
    public float volume;

    void Start()
    {
        fire = GetComponent<ParticleSystem>();
        fireSound = GetComponent<AudioSource>();

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            fire.Play();
            fireSound.PlayOneShot(fireClip, volume);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
