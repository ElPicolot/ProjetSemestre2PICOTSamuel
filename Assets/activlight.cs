using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activlight : MonoBehaviour
{
    public UnityEngine.Rendering.Universal.Light2D lightactiv;
    // Start is called before the first frame update
    void Start()
    {
        lightactiv.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Flamme");
        if (collision.gameObject.CompareTag("Girl1"))
        {

            Debug.Log("FlammeAllumer");





            lightactiv.enabled = true;
            //Door1.GetComponent<BoxCollider2D>().enabled = false;
            //Door1.GetComponent<SpriteRenderer>().color = new Color(255, 4, 226, 0);
        }
    }
}
