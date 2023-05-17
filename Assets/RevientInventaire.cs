using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevientInventaire : MonoBehaviour
{
    [SerializeField] public bool marionettepresente;
    [SerializeField] GameObject PlayerM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(!marionettepresente)
        {
           
        
        //transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        
        }
    }
}
