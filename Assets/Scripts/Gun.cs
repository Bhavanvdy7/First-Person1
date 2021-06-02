using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public GameObject impactEffect;
    public float impactForce = 10f;
    public AudioSource gunSound;
    public AudioClip gunClip;
    public float volume;

    public Camera FPSCam;


    // Start is called before the first frame update
    void Start()
    {
        FPSCam = Camera.main;
        gunClip = gameObject.GetComponent<AudioClip>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseFire()
    {
        gunSound.PlayOneShot(gunClip, 2f);
        Shoot();
    }

    public void Shoot ()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPSCam.transform.position, FPSCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
            }
            if (hit.rigidbody != null )
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
            GameObject impactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
            Destroy(impactGO, 2f);
        }
    }
}
