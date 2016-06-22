using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 3f;
    private Vector3 movement;
    private bool facingRight = true;
    private Animator anim;

    private Vector3 center;
    public float distFromCenter = 0f;

    void Start ()
    {
        anim = GetComponent<Animator>();
        center = new Vector3(0, 0, 0);
    }

    void Update ()
    {
        distFromCenter = Vector3.Distance(transform.position, center);

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (Mathf.Abs(h) > 0.1f || Mathf.Abs(v) > 0.1f)
            anim.SetBool("walk", true);
        else
            anim.SetBool("walk", false);

        if (h > 0)
        {
            if (facingRight == false)
                Flip();
        }
        else if (h < 0)
        {
            if (facingRight == true)
                Flip();
        }

        movement.Set(h, 0f, v);
        movement = movement.normalized * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
}
