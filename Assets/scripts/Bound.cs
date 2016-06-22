using UnityEngine;
using System.Collections;

public class Bound : MonoBehaviour
{
    public bool inBounds = true;

    void OnTriggerEnter(Collider other)
    {
        inBounds = true;
    }

    void OnTriggerExit(Collider other)
    {
        inBounds = false;
    }
}
