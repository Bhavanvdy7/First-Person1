using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FPSMovement : MonoBehaviour
{
    public Vector3 direction;
    public int speed;
    public float jumpForce;
    private bool jump;
    private bool isGrounded;
    private bool isCrouching;
    private float playerHeight;
    public float reducedHeight;
    private bool isSprinting;
    private int sprintSpeed;
    Vector3 verticalVelocity = Vector3.zero;

    [SerializeField]
    private GameObject pauseMenuUI;
    bool isPaused;

    public Rigidbody rb; //the player's rigid body
    CapsuleCollider playerCol;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        playerCol = gameObject.GetComponent<CapsuleCollider>();
        reducedHeight = 1;
        playerHeight = playerCol.height;
        sprintSpeed = speed * 2;
        pauseMenuUI.SetActive(false);
    }

    private void Update()
    {
        verticalVelocity.y = rb.position.y * Time.deltaTime;
        if (verticalVelocity.y > 0f)
        {
            isGrounded = false;
        }
        isGrounded = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //transform.Translate(direction * speed * Time.deltaTime);

        //world direction in local direction
        Vector3 localDirection = transform.TransformDirection(direction);
        //make the movement
        rb.MovePosition(rb.position + (localDirection * speed * Time.deltaTime));
        if (jump && isGrounded)
                {
                    rb.AddForce(rb.transform.up * jumpForce, ForceMode.Impulse);
                }
        jump = false;

        if (isCrouching == true)
        {
            playerCol.height = reducedHeight;
        } playerCol.height = playerHeight;

        if (isSprinting == true)
        {
            rb.MovePosition(rb.position + (localDirection * sprintSpeed * Time.deltaTime));
        }
        rb.MovePosition(rb.position + (localDirection * speed * Time.deltaTime));
    }

    public void OnMovement(InputValue value)
    {
        //a vector with x and y comnponents to WASD and arrow
        //both components are in the range [-1,1]
        Vector2 inputVector = value.Get<Vector2>();
        direction = new Vector3(inputVector.x, 0, inputVector.y);
        direction.x = inputVector.x;
        direction.z = inputVector.y;
    }

    public void OnJump ()
    {
        jump = true;
    }

    public void OnCrouchstart ()
    {
        isCrouching = true;
    }

    public void OnCrouchend ()
    {
        isCrouching = false;
    }

    public void OnSprintstart ()
    {
        isSprinting = true;
    }

    public void OnSprintend()
    {
        isSprinting = false;
    }

    public void OnPauseMenu()
    {
        isPaused = !isPaused;

        if (isPaused)
        {
            ActivateMenu();
        } else
        {
            DeactivateMenu();
        }
    }

    public void ActivateMenu()
    {
        Time.timeScale = 0;
        AudioListener.pause = true;
        pauseMenuUI.SetActive(true);
        Cursor.visible = true;
    }

    public void DeactivateMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        pauseMenuUI.SetActive(false);
        isPaused = false;
        Cursor.visible = false;
    }

}
