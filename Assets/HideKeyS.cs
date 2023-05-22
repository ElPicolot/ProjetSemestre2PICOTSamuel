using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideKeyS : MonoBehaviour
{
    private SpriteRenderer character;
    private Color col;
    private float activationTime;
    private bool invisible;
    bool canbeInvisible;
    int manaDispo = 100;
    int manaMax = 100;
    bool toucheApp=false;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<SpriteRenderer>();
        activationTime = 0;
        invisible = false;
        col = character.color;

    }

    // Update is called once per frame
    void Update()
    {
        activationTime += Time.deltaTime;
        if (invisible && activationTime >= 10)
        {
            invisible = false;
            col.a = 1;
            character.color = col;
        }
        if(canbeInvisible && toucheApp)
        {
            invisible = true;
            activationTime = 0;
            col.a = .2f;
            character.color = col;
        }
        /*if(Input.GetKey("r") && canbeInvisible &&)
        {
            toucheApp = !toucheApp;
            Debug.Log("A");
        }*/
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Invisible")
        {
            canbeInvisible = true;
            
        }
        if (other.tag == "PotionMana")
        {
            manaDispo += 100;
            //DestroyObject("PotionMana");
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Invisible")
        {
            invisible = false;
            col.a = 1;
            character.color = col;
        }

    }
}
