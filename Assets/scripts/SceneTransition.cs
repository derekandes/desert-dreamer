using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    private SpriteRenderer sp;
    public Transform center;
    public float distFromCenter = 0f;
    private CameraAnim cam;
    private bool doTransition = false;
    public float beginTransitionDist = 8f;

    void Start ()
    {
        sp = GetComponent<SpriteRenderer>();
        //center = new Vector3(0, 0, 0);
        cam = Camera.main.GetComponent<CameraAnim>();
    }

	void Update ()
    {
        distFromCenter = Vector3.Distance(transform.position, center.position);

        Color tmp = sp.color;

        float subtractor = distFromCenter - beginTransitionDist;
        if (subtractor < 0) subtractor = 0;

        float alpha = 255 - (subtractor * 50);
        tmp.a = Functions.Map01(alpha, 0f, 255f);
        sp.color = tmp;

        if (alpha < 0)
        {
            if (cam.camOn)
            {
                cam.TurnOff();
                doTransition = true;
                StartCoroutine(WaitForTransition());
            }
        }
        else
        {
            if (!cam.camOn)
            {
                cam.TurnOn();
                doTransition = false;
            }
        }
    }

    IEnumerator WaitForTransition()
    {
        yield return new WaitForSeconds(3);
        if (doTransition)
        {
            Application.Quit();
        }
    }
}
