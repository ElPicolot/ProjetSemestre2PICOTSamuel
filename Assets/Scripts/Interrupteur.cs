using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interrupteur : MonoBehaviour
{
    [SerializeField] bool InterrupteurGirl;

    bool canActivate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionStay2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Puppet2" && !InterrupteurGirl)
        {
            Debug.Log("Puppet !");
            canActivate = true;
            //Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Girl1" && InterrupteurGirl)
        {
            Debug.Log("Girl !");
            //Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Puppet2" && canActivate)
        {
            Debug.Log("Puppet can activate!");
            canActivate = true;
            //Destroy(gameObject);
        }
        if (collision.gameObject.tag == "Girl1" && canActivate)
        {
            Debug.Log("Girl can't activate!!");
            //Destroy(gameObject);
        }
    }
}
