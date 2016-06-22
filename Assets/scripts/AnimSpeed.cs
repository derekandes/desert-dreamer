using UnityEngine;
using System.Collections;

public class AnimSpeed : MonoBehaviour
{
    private Transform player;
    private Animator animator;
    private AudioSource audio;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
        audio = GetComponent<AudioSource>();
	}
	
	void Update ()
    {
	    float distance = Vector3.Distance(player.position, transform.position);
        float speed = 3f - distance;
        float audioSpeed = 3f - distance;
        if (speed < 0) speed = 0;
        if (speed > 1.5) speed = 1.5f;
        animator.speed = speed;

        if (audioSpeed < 0) audioSpeed = 0;
        if (audioSpeed > 2) audioSpeed = 2;
        if (audio)
        {
            audio.pitch = audioSpeed;
        }
    }
}
