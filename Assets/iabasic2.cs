using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iabasic2 : MonoBehaviour
{
    public bool IsHidden;
    public Transform target;
    [SerializeField] Transform depart;
    [SerializeField] public float speed = 5f;
    public GestionPlayer GestionPlayer;
    private void Update()
    {


        if (!IsHidden)
        {
            // transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if (IsHidden)
        {
            transform.position = Vector3.MoveTowards(transform.position, depart.position, speed * Time.deltaTime);
        }
        if (transform.position.y > 554)
        {
            transform.position = new Vector3(transform.position.x, 554, transform.position.z);
        }
        
        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }
    //modif script tentative de devenir insensible
}


