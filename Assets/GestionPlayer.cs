using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionPlayer : MonoBehaviour
{
    [SerializeField] GameObject PlayerF;
    [SerializeField] GameObject PlayerM;

    

    bool isSwitchAvailable = false;
    bool marionettedispo = false;
    int timeMarionnette = 5;
    bool player1Present;
    bool player2Present;
    //[SerializeField] GameObject 

    // Start is called before the first frame update
    void Start()
    {
        isSwitchAvailable = true;
         player1Present = true;
         player2Present = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("c"))
        {
            //&& isSwitchAvailable)
            //PlayerF.gameObject.GetComponent<DeplacementBasic>().enabled = false;
            //PlayerM.gameObject.GetComponent<DeplacementBasic>().enabled = true;

            if(isSwitchAvailable)
            {
                print("Possible");
            }
            if(marionettedispo)
            {
                print("Marioneete Disponible");
            }
            PlayerF.gameObject.SetActive(false);
            PlayerM.gameObject.SetActive(true);
            player1Present = false;
            player2Present = true;
            Debug.Log("player2" + player2Present);
            Debug.Log("player1" + player1Present);

            // active le sprite renderer
            // change le tag du player avec la marionette
            // anim ((invoc) 1sec) + effets speciaux
            // Coroutine
            // levite legerement puis tombe sur le sol
            // enabled playerF rigidbody2D

            marionettedispo = true;


            print("up arrow key is held down");
        }
        //&& isSwitchAvailable && marionettedispo)

        if (Input.GetKey("d"))
        
        {
            
            //PlayerM.gameObject.GetComponent<DeplacementBasic>().enabled = true;
            //PlayerF.gameObject.GetComponent<DeplacementBasic>().enabled = false;
            
            

            PlayerM.gameObject.SetActive(false);
            PlayerF.gameObject.SetActive(true);

            marionettedispo = false;
            player1Present = true;
            player2Present = false;

            Debug.Log("player2"+player2Present);
            Debug.Log("player1"+player1Present);



            // Rechanger player tag
            // Anim
            // Destory marionnette
            // 
            print("down arrow key is held down");
        }
    }
}
