using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    
    public GameObject other;
    private GameManager gameManager;
    
    
    void Start() 
            {
                 gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
            }
    
    
    private void OnCollisionEnter(Collision other) 
    {
         
        
        
        
        if(other.gameObject.tag == "Enemy")
        {
            Destroy(other.gameObject);
            gameManager.UpdateScore(3);
        }
    }
}
