using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 1.75f;
    private Vector3 movement;
    private bool facingRight = true;
    private Animator anim;
    private bool sitting = false;

    void Start ()
    {
        anim = GetComponent<Animator>();
    }

    void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sitting = !sitting;
        }

        anim.SetBool("sit", sitting);
        
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        if (Mathf.Abs(h) >= 0.01f || Mathf.Abs(v) >= 0.01f)
        {
            sitting = false;
            anim.SetBool("walk", true);
            anim.SetBool("sit", false);
        }
        else
        {
            anim.SetBool("walk", false);
        }

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
