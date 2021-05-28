using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Rotation Controls")]
    //Axis around which the gameObject is rotating
    [Tooltip("Axis around which the gameObject is rotating")]
    [SerializeField]
    private Vector3 rotationAxis = Vector3.up;
    //speed with which the gameObject is rotating.
    [Tooltip("speed with which the gameObject is rotating.")]
    public float rotationSpeed = 1f;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotationAxis, rotationSpeed);
    }
}
