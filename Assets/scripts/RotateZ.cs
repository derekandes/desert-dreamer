using UnityEngine;
using System.Collections;

public class RotateZ : MonoBehaviour
{
    public bool counter = false;
    public float speed = 10f;

	void Update ()
    {
        if (counter)
            transform.Rotate(0, 0, -Time.deltaTime * speed);
        else
            transform.Rotate(0, 0, Time.deltaTime * speed);
    }
}
