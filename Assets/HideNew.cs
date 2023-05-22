using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideNew : MonoBehaviour
{
    private SpriteRenderer character;
    private Color col;
    private float activationTime;
    private bool invisible;
    bool canBeInvisible = false;
    bool toucheAppuyer = false;
    [SerializeField] float time;
    [SerializeField] float timeStore;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<SpriteRenderer>();
        activationTime = 0;
        invisible = false;
        col = character.color;
        timeStore = time;
    }

    // Update is called once per frame
    void Update()
    {
        activationTime += Time.deltaTime;
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {

            if (invisible && activationTime >= 10)
            {
                invisible = false;
                col.a = 1;
                character.color = col;
            }
        }
        if (Input.GetKey("s") && canBeInvisible && (time<=0))
        {
            Debug.Log("Touche App");
            //toucheAppuyer = !toucheAppuyer;
            toucheAppuyer = true;
        }
        if(toucheAppuyer && canBeInvisible)
        {
            Debug.Log("Est invisble");
            invisible = true;
            activationTime = 0;
            col.a = .2f;
            character.color = col;
        }
        else
        {
            invisible = false;
            col.a = 1;
            character.color = col;
            //time = timeStore;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Invisible")
        {
            Debug.Log("Peut etre invisible");
            canBeInvisible = true;

        }
        
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Invisible")
        {
            Debug.Log("Deviens visible");
            canBeInvisible = false;
            toucheAppuyer = false;
            Debug.Log("Dois reapuyyer sur la touche");
        }

    }
}
