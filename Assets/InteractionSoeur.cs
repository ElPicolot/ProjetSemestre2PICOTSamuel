using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionSoeur : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entering");
        if (collision.gameObject.CompareTag("Interupteur1"))
        {

            


        }
        if (collision.gameObject.CompareTag("Interupteur2"))
        {

            
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Staying");


        if (collision.gameObject.CompareTag("Interupteur1"))
        {

            if (Input.GetKey("f"))
            {
                Debug.Log("f");
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Interupteur2"))
        {
            if (Input.GetKey("g"))
            {
                Debug.Log("g");
                
            }

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
        if (collision.gameObject.CompareTag("Interupteur1"))
        {

            

        }
        if (collision.gameObject.CompareTag("Interupteur2"))
        {

            
        }
    }

}

