using UnityEngine;
using UnityEditor;
using System.Collections;

public class Blowfish : MonoBehaviour
{
    private Rigidbody2D rigidBody;
    private CircleCollider2D circleCollider;

    [SerializeField]
    private float attackDuration = 1f;
    [SerializeField]
    private float attackRadius = 10f;
    private float initialRadius;
    private float t = 0f;
    private bool attacking = false;

    // Use this for initialization
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        circleCollider = GetComponent<CircleCollider2D>();

        initialRadius = circleCollider.radius;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void Move(Vector2 movement)
    {
        rigidBody.velocity = movement;
    }

    public void Attack(bool attack)
    {
        if (attack) attacking = true;
        if (attacking)
        {
            circleCollider.radius = Mathf.Lerp(initialRadius, attackRadius, IncrementT());
            if (t >= 1)
            {
                circleCollider.radius = initialRadius;
                attacking = false;
            }
        }
    }

    private float IncrementT()
    {
        if (t <= 1) t += Time.deltaTime / attackDuration;
        else t = 0f;
        return t;
    }
}
