using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Replay : MonoBehaviour
{
    // Start is called before the first frame update
    public void restart()
    {
        transform.localScale = new Vector3(1, 1, 1);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);

    }
}
