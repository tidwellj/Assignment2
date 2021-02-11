using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class st : MonoBehaviour
{
    public static float speeD;
    public void Change(float f)
    {
        if (f == 1)
        {

            GetComponent<Text>().text = "Easy";
            speeD = 800;
        }
        /*else if (f == 1)
        {
            //  GetComponent<Text>().text = f.ToString();
            GetComponent<Text>().text = "Medium";
            speeD = 500;//43275;
        }*/
        else if (f != 1)
        {
            GetComponent<Text>().text = "Difficult";
            speeD = 500;
        }


    }
}
