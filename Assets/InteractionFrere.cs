using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionFrere : MonoBehaviour
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
        if (collision.gameObject.CompareTag("Interupteur1"))
        {
            Debug.Log("Toucher");



        }
        if (collision.gameObject.CompareTag("Interupteur3"))
        {
            

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {



        if (collision.gameObject.CompareTag("Interupteur1"))
        {

            if (Input.GetKey("t"))
            {
                Debug.Log("t");
                Destroy(gameObject);
            }
        }
        if (collision.gameObject.CompareTag("Interupteur3"))
        {
            if(Input.GetKey("r"))
            {

                Debug.Log("r");
            }

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Interupteur1"))
        {



        }
        if (collision.gameObject.CompareTag("Interupteur3"))
        {


        }
    }
}
