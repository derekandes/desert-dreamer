using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class AnimSpeed : MonoBehaviour
{
    private Transform player;
    private Animator animator;
    AudioSource a;
    public float falloff = 3f;
    public float maxAudioSpeed = 2f;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
        a = GetComponent<AudioSource>();
	}
	
	void Update ()
    {
	    float distance = Vector3.Distance(player.position, transform.position);
        float speed = falloff - distance;

        animator.speed = Mathf.Clamp(speed, 0f, 1.5f);

        float audioSpeed = Mathf.Clamp(speed, 0f, maxAudioSpeed);
        a.pitch = audioSpeed;
    }
}
