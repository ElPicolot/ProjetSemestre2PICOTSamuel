
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D lightactiv;

    void Start()
    {

    }

    /*void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Girl1")
        {
            lightactiv.enabled = true;
        }
        else
        {
            lightactiv.enabled = false;
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Entering2");
        if (collision.gameObject.CompareTag("Girl1"))
        {

            Debug.Log("Entering2");





            lightactiv.enabled = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit2");
        if (collision.gameObject.CompareTag("Girl1"))
        {
            Debug.Log("Exit2");


            lightactiv.enabled = false;

        }
    }
}

