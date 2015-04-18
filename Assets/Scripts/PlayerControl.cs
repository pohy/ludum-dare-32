using UnityEngine;
using System.Collections;

[RequireComponent(typeof (Blowfish))]
public class PlayerControl : MonoBehaviour
{
    [SerializeField]
    private float movementSpeed;

    private Blowfish blowfish;

    private Vector2 movement;
    private bool attack;

    // Use this for initialization
    void Start()
    {
        blowfish = GetComponent<Blowfish>();
    }

    void FixedUpdate()
    {
        blowfish.Move(movement);
        blowfish.Attack(attack);
        attack = false;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal") * movementSpeed;
        movement.y = Input.GetAxis("Vertical") * movementSpeed;

        if (!attack)
        {
            attack = Input.GetKeyDown(KeyCode.C);
        }
    }
}
