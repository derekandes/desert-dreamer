using UnityEngine;
using System.Collections;

public class ConstSpeed : MonoBehaviour
{
    private Animator animator;

	void Start ()
    {
        animator = GetComponent<Animator>();
	}

	void Update ()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float speed = Mathf.Abs(h) + Mathf.Abs(v);
        animator.speed = Mathf.Clamp(speed + .15f, .15f, 1f);

        transform.localScale = new Vector3(Mathf.Clamp(0.5f + speed / 2, 0.5f, 1f), Mathf.Clamp(0.5f + speed / 2, 0.5f, 1f), 1);
        


    }
}
