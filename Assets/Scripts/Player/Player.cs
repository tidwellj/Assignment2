using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    Material SphereMaterial;
    public Color newColor;


    public event Action<Player> onPlayerDeath;
    public int health = 3;
    // Start is called before the first frame update
    // Use this for initialization
    void Start()
    {
        SphereMaterial = Resources.Load<Material>("ya");
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        // Get the current material applied on the GameObject
        Material oldMaterial = meshRenderer.material;
        Debug.Log("Applied Material: " + oldMaterial.name);
        // Set the new material on the GameObject
        // get color
        meshRenderer.material = SphereMaterial;
    }
    void collidedWithEnemy(Enemy enemy)
    {
        enemy.Attack(this);
        if (health <= 0)
        {
            
               
                if (onPlayerDeath != null)
                {

                onPlayerDeath(this);
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

            }


        }
        
    }
    

    void OnCollisionEnter(Collision col)
    {
        Enemy enemy = col.collider.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            collidedWithEnemy(enemy);
        }
    }
    private void Update()
    {
        MeshRenderer meshRenderer = GetComponent<MeshRenderer>();
        if (DropD.playerColor == "Red")
        {
            meshRenderer.material.color = Color.red;
        }
        else if (DropD.playerColor == "Blue")
        {
            meshRenderer.material.color = Color.blue;
        }

        else if (DropD.playerColor == "Green")
        {
            meshRenderer.material.color = Color.green;
        }

        
    }
}