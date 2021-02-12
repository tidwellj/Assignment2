using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextChange : MonoBehaviour
{
    public static float speeD;

   
        public  void Change(float f)
        {

            if (f == 1)
            {

                GetComponent<Text>().text = "Fast";
            Time.timeScale = 2;
        }
        else
            {
                GetComponent<Text>().text = "Slow";
            Time.timeScale = 1;
        }

    }
    
}
