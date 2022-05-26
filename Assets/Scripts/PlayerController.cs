using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float _speed=4.0f;
    private float horizontalInput;
    private float verticalInput;
    private float xRange=-30;
    private float lowerBound = -26;
    private float upperBound = 46;
    private Rigidbody playerRb;
    private bool isOnground= true;
 
    

   
    // Start is called before the first frame update
    void Start()
    {
        playerRb= GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput=Input.GetAxis("Horizontal");
        verticalInput= Input.GetAxis("Vertical");

        playerRb.AddForce(Vector3.right * _speed * horizontalInput);
        playerRb.AddForce(Vector3.forward *_speed * verticalInput);

        transform.Rotate(Vector3.one);


        if(Input.GetKeyDown(KeyCode.Space) && isOnground )
        {
            playerRb.AddForce(Vector3.up *_speed  ,ForceMode.Impulse);
            isOnground= false;
        }
        Bounds();
       
        
    }       
        void Bounds()
        {
            if(transform.position.x < xRange)
        {
            
            transform.position = new Vector3(-30 , transform.position.y, transform.position.z);
        }
        if(transform.position.x > -xRange)
        {
                transform.position = new Vector3(30 , transform.position.y, transform.position.z);
        }

        if(transform.position.z < lowerBound)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, -26);
        }
        if(transform.position.z > upperBound)
        {
            transform.position = new Vector3(transform.position.x , transform.position.y, 46);
        }
        }

       public void OnCollisionEnter(Collision other) 
        {

        isOnground= true;
        }

}
    


   
   

