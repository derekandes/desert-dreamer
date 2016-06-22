using UnityEngine;
using System.Collections;

public class Tumbleweed : MonoBehaviour
{
    public float speed = 2f;

	void Start ()
    {
        StartCoroutine(Die());
    }

    void Update ()
    {
        transform.Translate(-Time.deltaTime * speed, 0f, 0f);
	}

    IEnumerator Die()
    {
        yield return new WaitForSeconds(30);
        Destroy(gameObject);
    }
}
