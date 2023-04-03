using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleZone : MonoBehaviour
{
    private float activationTime;
    public iabasic ia;
    // Start is called before the first frame update

    private void Update()
    {
        activationTime += Time.deltaTime;
        if (ia.IsHidden && activationTime >= 13)
        {
            ia.IsHidden = false;


        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Girl1"))
        {
            ia.IsHidden = true;
        }
 
   }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Girl1"))
        {
            ia.IsHidden = false;
        }
    }
}
