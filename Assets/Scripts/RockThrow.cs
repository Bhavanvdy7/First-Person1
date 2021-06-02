using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockThrow : MonoBehaviour
{
    public GameObject focusedObject;

    public GameObject pickupSlot;
    float throwforce = 600;

    public float interactDistance;

    public bool isHolding;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isHolding)
            return;

        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        //hit va to store our results

        RaycastHit hit;

        //ray originating from the camera;
        Ray ray = new Ray(transform.position, fwd);

        //conduct raycast

        if (Physics.Raycast(ray, out hit))
        {
            focusedObject = hit.collider.gameObject;
        }
        else
        {
            focusedObject = null;
        }
        interactDistance = Vector3.Distance(focusedObject.transform.position, pickupSlot.transform.position);
        if (interactDistance >= 2f)
        {
            isHolding = false;
        }
    }

    public void OnThrowRock()
    {
        if (isHolding)
        {
            //Drop whatever holding
            focusedObject.transform.parent = null;
            focusedObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            focusedObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            focusedObject.GetComponent<Rigidbody>().isKinematic = false;
            focusedObject.GetComponent<Rigidbody>().AddForce(pickupSlot.transform.forward * throwforce);
            isHolding = false;
        } }

        public void OnPickupRock() {
           if (focusedObject.CompareTag("Rock") && interactDistance <= 2f)
            {
                focusedObject.transform.parent = pickupSlot.transform;
                focusedObject.transform.position = pickupSlot.transform.position;
                focusedObject.GetComponent<Rigidbody>().isKinematic = true;
                focusedObject.GetComponent<Rigidbody>().detectCollisions = true;
                isHolding = true;
            }
        } }



