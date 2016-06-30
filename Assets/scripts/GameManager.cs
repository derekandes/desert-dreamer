using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{

    // singleton
    public static GameManager instance { get; private set; }

    public float timer, minutes, seconds = 0f;

    void Awake ()
    {
        instance = this;
    }

    void Update()
    {
        // esc to quit
        if (Input.GetKey("escape"))
            Application.Quit();

        // keep track of inactive time
        timer += Time.deltaTime;
        minutes = Mathf.Floor(timer / 60);
        seconds = Mathf.RoundToInt(timer % 60);

        // reset inactive time on input
        if (Input.anyKeyDown)
        {
            timer = 0f;
            minutes = 0f;
            seconds = 0f;
        }

        // close after 5 minutes inactive
        if (minutes >= 5f)
        {
            Application.Quit();
        }
    }

    void OnDestroy()
    {
        // clean up
        if (instance != null)
        {
            instance = null;
        }
    }
}
