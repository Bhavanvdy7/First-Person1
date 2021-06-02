using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieLookAtPlayer : MonoBehaviour
{

    public Transform target;
    public float speed;
    public GameObject died;

    // Update is called once per frame
    void Update()
    {
        // calculate the relative position between this gameObject and the target
        Vector3 relativeRos = target.position - transform.position;
        //project the relative pos onto the XZ plane to rotate around Y
        Vector3 relativeXZ = Vector3.ProjectOnPlane(relativeRos, Vector3.up);

        // create a look roatation the UFO in the direction of the relative position

        Quaternion lookRot = Quaternion.LookRotation(relativeXZ);

        // Apply to game object

        transform.rotation = lookRot;
        transform.Translate(new Vector3(0, 0, speed * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            died.SetActive(true);
            Debug.Log("died");
            Cursor.visible = true;
        }
    }


}
