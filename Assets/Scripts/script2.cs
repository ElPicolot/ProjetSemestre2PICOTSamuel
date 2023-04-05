
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script2 : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D lightactiv2;
    [SerializeField] GameObject Door2;

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
            //gameObject.tag = "porte2";
            //Destroy(door);box et rigidboy opacite alpha couleur
            Door2.GetComponent<BoxCollider2D>().enabled = false;
            Door2.GetComponent<SpriteRenderer>().color = new Color(255, 147, 0, 125);

        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit2");
        if (collision.gameObject.CompareTag("Puppet2"))
        {
            Debug.Log("Exitbis");


            lightactiv2.enabled = false;
            Door2.GetComponent<BoxCollider2D>().enabled = true;
            Door2.GetComponent<SpriteRenderer>().color = new Color(255, 147, 0, 255);

        }
    }
}