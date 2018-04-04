using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    public float speed;

    private Rigidbody rb;

    private bool isFalling = true;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    
    void OnCollisionStay ()
    {
        isFalling = false;
    }

    void FixedUpdate ()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow) && isFalling == false)
        {
            rb.velocity = new Vector3(0f, 10f, 0f);
            isFalling = true;
        }

        float moveHorizontal = Input.GetAxis ("Horizontal");

        Vector3 movement = new Vector3 (moveHorizontal, 0.0f, 0.0f);

        rb.AddForce (movement * speed);
    }
    //to make sure you can't jump while in mid-air I use the following:

}