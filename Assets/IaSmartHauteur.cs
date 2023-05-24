using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IaSmartHauteur : MonoBehaviour
{
    public bool IsHidden;
    public Transform target;
    [SerializeField] Transform depart;
    [SerializeField] public float speed = 5f;
    public GestionPlayer GestionPlayer;
    [SerializeField] int hauteur;
    //[SerializeField] int range;
    //[SerializeField] GameObject object2;
    //int verif;
    private void Update()
    {
        /*Vector3 difference = new Vector3(v1.x - v2.x,v1.y - v2.y,v1.z - v2.z);
        float distance = Math.Sqrt(Math.Pow(difference.x, 2f) +Math.Pow(difference.y, 2f) );
        Vector3.Distance(target.transform.position, object2.transform.position);*/
        if (!IsHidden)
        {
            // transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else if (IsHidden)
        {
            transform.position = Vector3.MoveTowards(transform.position, depart.position, speed * Time.deltaTime);
        }
        if (transform.position.y > hauteur)
        {
            transform.position = new Vector3(transform.position.x, hauteur, transform.position.z);
        }

        transform.Translate(Vector2.right * speed * Time.deltaTime);

    }
    //modif script tentative de devenir insensible
}


