
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D lightactiv2;

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
        Debug.Log("Enteringbis");
        if (collision.gameObject.CompareTag("Puppet2"))
        {

            Debug.Log("Enteringbis");





            lightactiv2.enabled = true;

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit2");
        if (collision.gameObject.CompareTag("Puppet2"))
        {
            Debug.Log("Exitbis");


            lightactiv2.enabled = false;

        }
    }
}