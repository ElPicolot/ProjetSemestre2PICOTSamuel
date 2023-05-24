
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteMagique : MonoBehaviour
{
    [SerializeField] GameObject Door2;
    bool contactInter2;
    [SerializeField] bool porteactiv2;
    [SerializeField] float time2;
    [SerializeField] float timeStore2;
    [SerializeField] Sprite porteActiver2;
    [SerializeField] Sprite porteDesactiver2;
    [SerializeField] Sprite levierBas2;
    [SerializeField] Sprite levierHaut2;
    public SpriteRenderer spriteRenderer2; 


    // Start is called before the first frame update
    void Start()
    {
        timeStore2 = time2;
    }

    // Update is called once per frame
    void Update()
    {
        if (time2 > 0)
        {
            time2 -= Time.deltaTime;
        }
        else
        {
            if (contactInter2 && Input.GetKey("u") && !porteactiv2)
            {
                Debug.Log("u");
                Door2.GetComponent<BoxCollider2D>().enabled = false;
                //Door1.GetComponent<SpriteRenderer>().color = new Color(100, 100, 100, 100);
                Door2.GetComponent<SpriteRenderer>().sprite = porteDesactiver2;
                spriteRenderer2.sprite = levierBas2;
                Debug.Log("VerifOuvre");
                porteactiv2 = !porteactiv2;
                time2 = timeStore2;

            }
            else if (contactInter2 && Input.GetKey("u") && porteactiv2)
            {
                Debug.Log("u");
                Door2.GetComponent<BoxCollider2D>().enabled = true;
                //Door1.GetComponent<SpriteRenderer>().color = new Color(200, 200, 200, 200);
                Door2.GetComponent<SpriteRenderer>().sprite = porteActiver2;
                Debug.Log("VerifFerme");
                spriteRenderer2.sprite = levierHaut2;
                porteactiv2 = !porteactiv2;
                time2 = timeStore2;

            }

        }




    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Puppet2"))
        {
            contactInter2 = true;
            Debug.Log("EnterPuppet");
        }
    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Puppet2"))
        {
            contactInter2 = false;
            Debug.Log("ExitPuppet");
        }
    }
}