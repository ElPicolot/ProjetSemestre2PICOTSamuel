using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPlayer : MonoBehaviour
{
    [SerializeField] GameObject PlayerF;
    [SerializeField] GameObject PlayerM;

    

    bool isSwitchAvailable = false;
    bool marionettedispo = false;

    // Start is called before the first frame update
    void Start()
    {
        isSwitchAvailable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("c") && isSwitchAvailable)
        {

            // active le sprite renderer
            // change le tag du player avec la marionette
            // anim ((invoc) 1sec) + effets speciaux
            // Coroutine
            // levite legerement puis tombe sur le sol
            marionettedispo = true;


            print("up arrow key is held down");
        }

        if (Input.GetKey("d") && isSwitchAvailable && marionettedispo)
        {   // Rechanger player tag
            // Anim
            // Destory marionnette
            // 
            print("down arrow key is held down");
        }
    }
}
