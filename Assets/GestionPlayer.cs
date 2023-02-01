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
        if (Input.GetKey("c")) /*&& isSwitchAvailable)*/
        {
            
            PlayerF.gameObject.GetComponent<DeplacementBasic>().enabled = false;
            PlayerM.gameObject.GetComponent<DeplacementBasic>().enabled = true;
            
            

            PlayerF.gameObject.SetActive(false);
            PlayerM.gameObject.SetActive(true);

            // active le sprite renderer
            // change le tag du player avec la marionette
            // anim ((invoc) 1sec) + effets speciaux
            // Coroutine
            // levite legerement puis tombe sur le sol
            // enabled playerF rigidbody2D

            marionettedispo = true;


            print("up arrow key is held down");
        }

        if (Input.GetKey("d")) /*&& isSwitchAvailable && marionettedispo)*/
        {
            
            PlayerM.gameObject.GetComponent<DeplacementBasic>().enabled = true;
            PlayerF.gameObject.GetComponent<DeplacementBasic>().enabled = false;
            
            

            PlayerM.gameObject.SetActive(false);
            PlayerF.gameObject.SetActive(true);

            marionettedispo = false;



            // Rechanger player tag
            // Anim
            // Destory marionnette
            // 
            print("down arrow key is held down");
        }
    }
}
