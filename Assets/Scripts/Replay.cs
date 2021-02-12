using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{

    public void Start()
    {
        transform.localScale = new Vector3(1, 1, 1);
        BallSize.size = 0;
    }


    public void restart()
    {
        transform.localScale = new Vector3(1, 1, 1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
        Time.timeScale = 1;
    }
}
