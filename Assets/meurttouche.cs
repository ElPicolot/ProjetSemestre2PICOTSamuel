using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meurttouche : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ennemi1"))
        {
            Debug.Log("MeurtEnnemi1");

        }
        if (collision.gameObject.CompareTag("Ennemi2")) 
        {
            Debug.Log("MeurtEnnemi2");
        }
        if (collision.gameObject.CompareTag("Jafar"))
        {
            Debug.Log("MeurtJafar");
        }
        if (collision.gameObject.CompareTag("Trou"))
        {
            Debug.Log("MeurtTrou");
        }
    }
}
