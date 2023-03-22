using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iabasic : MonoBehaviour
{
    void Start()
    {
        
    }

    // Start is called before the first frame update
    public Transform target;
    [SerializeField] public float speed = 5f;
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        if (true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        }
    }
}


  