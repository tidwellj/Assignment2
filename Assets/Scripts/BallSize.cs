using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallSize : MonoBehaviour
{
    public static int size = 0;
    public void Change(float f)
    {
        if (f == 1)
        {
            //  GetComponent<Text>().text = f.ToString();
            GetComponent<Text>().text = "Large";
            size = 1;
        }
      /*  else if (f == 2)
        {
            GetComponent<Text>().text = "Large";

        } */
        else if (f == 0)
        {
            GetComponent<Text>().text = "Small";
            size = 0;
        }

    }
}
