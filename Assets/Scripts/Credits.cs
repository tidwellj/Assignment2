
using UnityEngine;

public class Credits : MonoBehaviour
{

    public void Quit()
    {
        transform.localScale = new Vector3(1, 1, 1);

        Debug.Log("Quit");
        Application.Quit();
    }
}
