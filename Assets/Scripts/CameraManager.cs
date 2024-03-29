using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField] GameObject playerRef;
    [SerializeField] GameObject playerRef2;
    Vector3 refVelocity = Vector3.zero;
    float smoothTime = 0.2f;
    [SerializeField] public bool player1Present;
    
    [SerializeField] public bool player2Present;
    

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //swtich camera
        //meme imput
        //ld (cadre plan de camera objectif se trouve ici
        if(player1Present)
        {
            Vector3 targetPosition = new Vector3(playerRef.transform.position.x, playerRef.transform.position.y, -10);
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPosition, ref refVelocity, smoothTime);
        }
        else {
            Vector3 targetPosition = new Vector3(playerRef2.transform.position.x, playerRef2.transform.position.y, -10);
            gameObject.transform.position = Vector3.SmoothDamp(gameObject.transform.position, targetPosition, ref refVelocity, smoothTime);
        }
    }
}
