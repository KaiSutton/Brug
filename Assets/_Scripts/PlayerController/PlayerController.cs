using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    // the physics component of the object
    Rigidbody rb;

    public float speed = 5;
    public int score;
    public Text scoreText;


    //jumping variables
    public bool grounded = true;
    public float jumpForce = 20f;
    public Transform groundCheck;
    public LayerMask groundMask;
    public float groundDist = .2f;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MoveBall();
        HandleJump();

    }

    private void MoveBall()
    {
        float x = InputManager.instance.move.x;
        float y = InputManager.instance.move.y;
        Vector3 movement = new Vector3(x, 0, y);
        rb.AddForce(movement * speed);
    }

    private void HandleJump()
    {
        //check if we are grounded
        grounded = Physics.CheckSphere(groundCheck.position, groundDist, groundMask);


        //if we are being grounded and the jump button is being pressed
        if (InputManager.instance.jumpPressed && grounded)
        {
            //jump
            rb.AddForce(0, jumpForce, 0);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            score++;
            scoreText.text = "Score:" + score;
        }
    }

}
