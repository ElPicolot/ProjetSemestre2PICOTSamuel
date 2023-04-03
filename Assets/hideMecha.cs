using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hideMecha : MonoBehaviour
{
    private SpriteRenderer character;
    private Color col;
    private float activationTime;
    private bool invisible;
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
        if(invisible && activationTime >= 10 )
        {
            invisible = false;
            col.a = 1;
            character.color = col;



        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Invisible")
        {
            invisible = true;
            activationTime = 0;
            col.a = .2f;
            character.color = col;
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
