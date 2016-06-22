using UnityEngine;
using System.Collections;

public class RotateZ : MonoBehaviour
{
	void Update ()
    {
        transform.Rotate(0, 0, Time.deltaTime + .1f);
	}
}
