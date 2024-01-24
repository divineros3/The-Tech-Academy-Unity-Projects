using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour
{
    public float speed;
    private Rigidbody rigb;

    private void Start()
    {
        rigb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHoriz, 0.0f, moveVert);
        rigb.AddForce(movement * speed);
    }
}
