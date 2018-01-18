using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animation;
    private Rigidbody playerRigidbody;
    public float moveSpeed = 10f;

	void Start ()
	{
	    playerRigidbody = GetComponent<Rigidbody>();
        animation = GetComponent<Animator>();
	}

	void Update ()
	{
	    Move();
	}

    void Move()
    {
        float horizontal = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float vertical = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        Vector3 movement = new Vector3(horizontal, 0f, vertical);

        playerRigidbody.AddForce(movement);

        transform.Translate(movement);
    }
}
