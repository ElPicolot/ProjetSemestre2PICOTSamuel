using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombianaisonDes2scripts : MonoBehaviour
{
    float distance = 2f;
    public float speedb = 5f;
    public float speeda = 5f;
    private bool movingRight = true;
    public Transform groundDetection;
    public Transform target;
    // Start is called before the first frame update

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(distance>10000)
        if(Input.GetButtonDown("P"))
        {
            //deplacementia();
             transform.position = Vector3.MoveTowards(transform.position, target.position, speeda * Time.deltaTime);
        
            RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down,distance);
            if(groundInfo.collider == false)
            {
                if (movingRight == true)
                {
                    transform.eulerAngles = new Vector3(0, -180, 0);
                    movingRight = false;
                }
                else
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    movingRight = true;
                }
            }
        }
        if(Input.GetButtonDown("J"))
        {
                //iafollow();
                transform.position = Vector3.MoveTowards(transform.position, target.position, speedb * Time.deltaTime);
                if (transform.position.y == 3) 
                {
                    transform.position = new Vector3(transform.position.x, 3, transform.position.z);
                }
        }
    }
        
            
           
    
}
