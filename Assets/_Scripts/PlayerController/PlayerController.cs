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
    public int coinsRemaing;


    //jumping variables
    public bool grounded = true;
    public float jumpForce = 20f;
    public Transform groundCheck;
    public LayerMask groundMask;
    public float groundDist = .2f;


    // Start is called before the first frame update

    //spawn vars
    Vector3 spawn = new Vector3 (0, 1, 0);
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.transform.position = spawn;
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

            //count down the remaining coins
            
            coinsRemaing--;
            
            // if no more remaining coins, load the next scene
            if (coinsRemaing == 0)
            {
                SceneSwitcher.instance.ChangeScene();
            }
        }

        if (other.CompareTag("Death"))
        {
            Reset();
        }


    }

    public void Reset()
    {
        transform.position = spawn;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

}
