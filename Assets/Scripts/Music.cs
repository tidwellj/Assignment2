using UnityEngine;
using System.Collections;

public class Music : MonoBehaviour
{

    private GameObject[] music;

    void Start()
    {
        music = GameObject.FindGameObjectsWithTag("GameMusic");
        Destroy(music[1]);
    }

    // Update is called once per frame
    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }
}
