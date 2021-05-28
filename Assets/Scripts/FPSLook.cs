using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPSLook : MonoBehaviour
{
    public Camera playerCamera;

    //Container variables for the mouse delta values
    public float deltaX;
    public float deltaY;

    //for the player's rotation around the X and Y axis

    public float xRot;
    public float yRot;
    // Start is called before the first frame update
    // Start is called before the first frame update
    void Start()
    {
        playerCamera = Camera.main;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //keep track of the player's x and y rotation
        yRot += deltaX;
        xRot -= deltaY;


        //keep the player's x rotation clamped to [-90,90] degrees
        xRot = Mathf.Clamp(xRot, -90f, 90f);

        //rotate the camera around x-axis
        playerCamera.transform.localRotation = Quaternion.Euler(xRot, 0, 0);
        transform.rotation = Quaternion.Euler(0, yRot, 0);
    }

    public void OnLook(InputValue value)
    {
        //reading the mouse deltas as a vector 2 deltax is the x component and deltay is the y component
        Vector2 inputVector = value.Get<Vector2>();
        deltaX = inputVector.x;
        deltaY = inputVector.y;
    }

}
