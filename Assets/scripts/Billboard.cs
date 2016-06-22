using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {

    private GameObject cam;
    private SpriteRenderer sp;

    void Awake()
    {
        cam = GameObject.Find("Main Camera");
        sp = GetComponent<SpriteRenderer>();
        sp.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
    }

    void Update()
    {
        if (cam)
        {
            transform.rotation = cam.transform.rotation;
        }
    }
}
