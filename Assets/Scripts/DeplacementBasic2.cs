using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementBasic2 : MonoBehaviour
{


    float MovementX2;
    float MovementY2;
    [SerializeField] float speed2;
    Rigidbody2D Rb;
    /*
    float moveSpeed = 10;
    //Define the speed at which the object moves.

    float horizontalInput = Input.GetAxis("Horizontal2");
    //Get the value of the Horizontal input axis.

    
    //Get the value of the Vertical input axis.
    // Start is called before the first frame update*/
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        /* Ici, on utilise un get axis pour avoir la sensibilité 
        pour utiliser eventuellemnt une manette avec des joystic */

        /*MovementX2 = Input.GetAxisRaw("Horizontal");
        MovementY2 = Input.GetAxisRaw("Vertical");

        Rb.velocity = new Vector2(MovementX2 * speed2 * Time.deltaTime, MovementY2 * speed2 * Time.deltaTime);
        */
        /*
        if (Input.GetKey("k"))
        {
            transform.position += Vector3.left * speed2 * Time.deltaTime;
        }
        if (Input.GetKey("m"))
        {
            transform.position += Vector3.right * speed2 * Time.deltaTime;
        }
        */
        /*if (Input.GetKey("o"))
        {
            transform.position += Vector3.up * speed2 * Time.deltaTime;
        }*/
        /*
        if (Input.GetKey("l"))
        {
            transform.position += Vector3.down * speed2 * Time.deltaTime;
        }*/
        /*
        if (Input.GetKey("k"))
        {
            transform.position += Vector3.left * speed2 * Time.deltaTime;
        }
        if (Input.GetKey("m"))
        {
            
        }*/

        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed2 * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed2 * Time.deltaTime;
        }
        
        
        
        /*
        transform.Translate(new Vector3(horizontalInput, 0, 0) * moveSpeed * Time.deltaTime);
        //Move the object to XYZ coordinates defined as horizontalInput, 0, and verticalInput respectively.*/
    }
}

