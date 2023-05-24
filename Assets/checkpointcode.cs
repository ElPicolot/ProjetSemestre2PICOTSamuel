using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpointcode : MonoBehaviour
{
    //[SerializeField] GameObject Door1;
    bool touche;
    bool toucheLast;
    [SerializeField] bool activer;
    //[SerializeField] bool porteactiv;
    //[SerializeField] float time;
    //[SerializeField] float timeStore;
    [SerializeField] Sprite checkPointActiver;
    [SerializeField] Sprite checkPointDesactiver;
    /*[SerializeField] Sprite levierBas;
    [SerializeField] Sprite levierHaut;
    */
    public SpriteRenderer spriteRenderer;


    // Start is called before the first frame update
    void Start()
    {
        //timeStore = time;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (time > 0)
        {
            time -= Time.deltaTime;
        }*/
        //else
        //{
           /* if (contactInter && Input.GetKey("r") && !porteactiv)
            {
                Debug.Log("r");
                Door1.GetComponent<BoxCollider2D>().enabled = false;
                //Door1.GetComponent<SpriteRenderer>().color = new Color(100, 100, 100, 100);
                Door1.GetComponent<SpriteRenderer>().sprite = porteDesactiver;
                spriteRenderer.sprite = levierBas;
                Debug.Log("VerifOuvre");
                porteactiv = !porteactiv;
                //time = timeStore;

            }
            else if (contactInter && Input.GetKey("r") && porteactiv)
            {
                Debug.Log("r");
                Door1.GetComponent<BoxCollider2D>().enabled = true;
                //Door1.GetComponent<SpriteRenderer>().color = new Color(200, 200, 200, 200);
                Door1.GetComponent<SpriteRenderer>().sprite = porteActiver;
                Debug.Log("VerifFerme");
                spriteRenderer.sprite = levierHaut;
                porteactiv = !porteactiv;
               // time = timeStore;
            
            }*/

        //}




    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Girl1")&& !activer)
        {
            //contactInter = true;
            Debug.Log("CheckPointActiver");
            spriteRenderer.sprite = checkPointActiver;
            activer = true;

        }
        if (collision.gameObject.CompareTag("Girl1") && activer)
        {
            //contactInter = true;
            //Door1.GetComponent<SpriteRenderer>().sprite = porteDesactiver;
            Debug.Log("DejaActiver");
            //activer = true;

        }
    }
    /*void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Girl1"))
        {
            contactInter = false;
            Debug.Log("ExitGirl");
        }
    }*/
}