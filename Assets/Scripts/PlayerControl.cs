using UnityEngine;
using System.Collections;

public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    private Rigidbody2D rigidBody;

    public Vector2 movement;
    public bool attack;

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
        attack = false;

        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");

        attack = Input.GetButtonDown("C");
    }
}
