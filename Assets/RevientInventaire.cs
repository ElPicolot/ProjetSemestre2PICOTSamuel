using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevientInventaire : MonoBehaviour
{
    // L Ia te fonce dessus a vole d oiseau 
    [SerializeField] SummonCam  present2 ;
    public Transform target ;
    [SerializeField] public float speed ;

    private void Update()
    {
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
            Debug.Log("N'est plus du tou tpresent");
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        }
}

    

