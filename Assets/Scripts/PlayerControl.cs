using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    private Rigidbody2D rigidBody;

    private Vector2 movement;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rigidBody.velocity = movement * movementSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
    }
}
