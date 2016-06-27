using UnityEngine;
using System.Collections;

public class CameraAnim : MonoBehaviour
{
    private Animator anim;
    public bool camOn = false;

	void Start ()
    {
        anim = GetComponent<Animator>();
        anim.SetTrigger("cameraOn");
        camOn = true;
	}

    void Update ()
    {

    }

    public void TurnOn ()
    {
        camOn = true;
        anim.SetTrigger("cameraOn");
    }

    public void TurnOff ()
    {
        camOn = false;
        anim.SetTrigger("cameraOff");
    }
}
