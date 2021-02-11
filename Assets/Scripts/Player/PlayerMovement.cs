using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float acceleration;
    public float maxSpeed;
    private Rigidbody rigidBody;
    private KeyCode[] inputKeys;
    private Vector3[] directionsForKeys;
    public int count = 0;
    GameObject button;
    public static int staTe = 0;
    GameObject playerSphere;
    public static int siZe = 0;

    public void Start()
    {
        button = GameObject.Find("Button");
        // button.SetActive(false);
        playerSphere = GameObject.Find("Player");

        inputKeys = new KeyCode[] { KeyCode.W, KeyCode.A, KeyCode.S, KeyCode.D };
        directionsForKeys = new Vector3[] { Vector3.forward, Vector3.left, Vector3.back, Vector3.right };
        rigidBody = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {

        for (int i = 0; i < inputKeys.Length; i++)
        {
            var key = inputKeys[i];


            if (Input.GetKey(key))
            {

                Vector3 movement = directionsForKeys[i] * acceleration * Time.deltaTime;


                movePlayer(movement);


            }







        }













        void movePlayer(Vector3 movement)
        {
            if (rigidBody.velocity.magnitude * acceleration > maxSpeed)
            {
                rigidBody.AddForce(movement * -1);

            }
            else
            {
                rigidBody.AddForce(movement);
            }
        }

    }
    void Update()
    {
        if ((Input.GetKeyDown("space")) && (staTe == 0))
        {

            //button.SetActive(true);

            Time.timeScale = 0;
            staTe = 1;




        }
        else if ((Input.GetKeyDown("space")) && (staTe == 1))
        {
            Time.timeScale = 1;
            staTe = 0;


        }



        //if (Input.GetKeyDown("f") && (siZe == 0))
        if (BallSize.size == 1)
        {
            //playerSphere.gameObject.transform.localScale += newVector3(0, 50, 0);
            transform.localScale = new Vector3(2, 2, 2);
            siZe = 1;

        }


        //else if ((Input.GetKeyDown("f") && (siZe == 1)))
        else if(BallSize.size == 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            siZe = 0;
        }
    }


       
        
        

    }