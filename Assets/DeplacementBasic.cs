using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeplacementBasic : MonoBehaviour
{
    public float speed;

    float MovementX;
    float MovementY;
    [SerializeField] bool is_jumping = false;
    [SerializeField] bool grounded = false;
    float jumpForce = 12000f;

    Rigidbody2D Rb;
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        /* Ici, on utilise un get axis pour avoir la sensibilité 
        pour utiliser eventuellemnt une manette avec des joystic */

        MovementX = Input.GetAxisRaw("Horizontal");
        MovementY = Input.GetAxisRaw("Vertical");

        Rb.velocity = new Vector2(MovementX * speed * Time.deltaTime, MovementY * speed * Time.deltaTime);

        if (Input.GetButtonDown("Jump") && grounded)
        {
            is_jumping = true;
        }

    }
    void FixedUpdate()
    {
        // Jump
        if (is_jumping && grounded)
        {
            is_jumping = false;
            Rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
            grounded = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Plateforme"))
        {

            grounded = true;
            

        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;


        if (collision.gameObject.CompareTag("Plateforme"))
        {
           
            grounded = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Plateforme"))
        {
            
            grounded = false;
            Rb.gravityScale = 3f;

        }
    }
}
