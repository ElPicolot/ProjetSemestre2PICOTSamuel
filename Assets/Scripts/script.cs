
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D lightactiv;
    [SerializeField] GameObject Door1;

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
            Door1.GetComponent<BoxCollider2D>().enabled = false;
            Door1.GetComponent<SpriteRenderer>().color = new Color(255, 4, 226, 0);
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit2");
        if (collision.gameObject.CompareTag("Girl1"))
        {
            Debug.Log("Exit2");


            lightactiv.enabled = false;
            Door1.GetComponent<BoxCollider2D>().enabled = true;
            Door1.GetComponent<SpriteRenderer>().color = new Color(255, 4, 226, 255);

        }
    }
}

