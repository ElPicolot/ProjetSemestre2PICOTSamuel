using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionFrere : MonoBehaviour
{
    bool onInteru1 = false;
    bool onInteru2 = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(onInteru1)
        {
            if(Input.GetKey("f"))
            {
                Debug.Log("f");
            }

        }
        if (onInteru2)
        {
            if (Input.GetKey("g"))
            {
                Debug.Log("g");
            }

        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entering");
        if (collision.gameObject.CompareTag("Interupteur1"))
        {

            onInteru1 = true;


        }
        if (collision.gameObject.CompareTag("Interupteur2"))
        {

            onInteru2 = true;

        }
    }
    /*private void OnTriggerStay2D(Collider2D collision)
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
    }*/
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");
        if (collision.gameObject.CompareTag("Interupteur1"))
        {

            onInteru1 = false;

        }
        if (collision.gameObject.CompareTag("Interupteur2"))
        {
            
            onInteru2 = false;


        }
    }

}
