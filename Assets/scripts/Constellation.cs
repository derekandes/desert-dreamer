using UnityEngine;
using System.Collections;

public class Constellation : MonoBehaviour
{
    private SceneTransition sceneScript;
    public float pDistFromCenter = 0;

    private SpriteRenderer sp;
    private Animator animator;
    private Transform player;

	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        sceneScript = player.gameObject.GetComponent<SceneTransition>();
        sp = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
	}
	
	void Update ()
    {
        if (sceneScript != null)
        {
            pDistFromCenter = sceneScript.distFromCenter;
        }

        CalcAlpha();
        CalcSpeed();
	}

    void CalcAlpha()
    {
        Color tmp = sp.color;
        float addToAlpha = Mathf.Clamp(pDistFromCenter - 6f, 0, 10f) * 30f;
        float alpha = Mathf.Clamp(5f + addToAlpha, 0f, 255f);
        tmp.a = Functions.Map01(alpha, 0f, 255f);
        sp.color = tmp;
    }

    void CalcSpeed()
    {
        float animSpeed = Mathf.Clamp(.02f + pDistFromCenter / 20, .02f, .75f);
        animator.speed = animSpeed;
    }
}
