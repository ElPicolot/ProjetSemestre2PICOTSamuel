using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevientInventaire : MonoBehaviour
{
    // L Ia te fonce dessus a vole d oiseau 
    [SerializeField] SummonCam  present2 ;
    public Transform target ;
    [SerializeField] public float speed ;
    [SerializeField] public float speedOuf;
    [SerializeField] float distance;
    [SerializeField] public GameObject object1;
    [SerializeField] float range;


    private void Update()
    {
        distance = Vector3.Distance(object1.transform.position, target.transform.position);
        //transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        Debug.Log(" pas present");
        //transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //if (!(present2.present))
        //if (GameObject.Find("Fille").GetComponent<SummonCam>().present)

        /*if(true)
        {
            Debug.Log("N'est plus du tou tpresent");
            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }*/
        if (!(present2.present))
        {
            if (distance < range)
            {
                Debug.Log("N'est plus du tou tpresent");
                transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            }
            else
            {
                Debug.Log("N'est plus du tou tpresent");
                transform.position = Vector3.MoveTowards(transform.position, target.position, speedOuf * Time.deltaTime);
            }
        }
        //if trop loin va super vite sinon va lentement
        }
}

    

