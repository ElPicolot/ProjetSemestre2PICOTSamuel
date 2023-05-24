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
    float manaMax = 200;
    float manaDispo;
    [SerializeField] bool present;
    //[SerializeField] GameObject 

    // Start is called before the first frame update
    void Start()
    {
        isSwitchAvailable = true;
        manaDispo = manaMax;
         
    }

    // Update is called once per frame
    void Update()
    {
        if(manaDispo>manaMax)
        {
            manaDispo = manaMax;
        }
        manaDispo += 0.1f;
        Debug.Log("On a"+manaDispo);
        Debug.Log("On a" + marionettedispo);
        //switch cam
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
            //PlayerF.gameObject.SetActive(false);
            //PlayerM.gameObject.SetActive(true);

            GetComponent<CameraManager>().player1Present = false;
            GetComponent<CameraManager>().player2Present = false;
            //Debug.Log("player2" + player2Present);
            //Debug.Log("player1" + player1Present);

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
        //switch cam aussi
        if (Input.GetKey("d"))
        
        {
            
            //PlayerM.gameObject.GetComponent<DeplacementBasic>().enabled = true;
            //PlayerF.gameObject.GetComponent<DeplacementBasic>().enabled = false;
            
            //Image assis atteint
            //De ne pas desactiver daeja 
            //Donc prendre des degats 
            // Borner la cam (A faire)
            //Recast player 1 player 2 
            // si depasse certaines distance bloque 

            // Ajout ennemi a fon avec interaction collision = dead + anim attaque ennemi
            

            //PlayerM.gameObject.SetActive(false);
            //PlayerF.gameObject.SetActive(true);

            marionettedispo = false;
            GetComponent<CameraManager>().player1Present = true;
            GetComponent<CameraManager>().player2Present = true;

            //Debug.Log("player2"+player2Present);
            //Debug.Log("player1"+player1Present);



            // Rechanger player tag
            // Anim
            // Destory marionnette
            // 
            print("down arrow key is held down");
        }
        //switch perso
        if (Input.GetKey("z"))
        {
            //&& isSwitchAvailable)
            //PlayerF.gameObject.GetComponent<DeplacementBasic>().enabled = false;
            //PlayerM.gameObject.GetComponent<DeplacementBasic>().enabled = true;

            if (isSwitchAvailable)
            {
                print("Possible");
            }
            if (marionettedispo)
            {
                print("Marioneete Disponible");
            }
            //PlayerF.gameObject.SetActive(false);
            PlayerM.gameObject.SetActive(true);

            //GetComponent<CameraManager>().player1Present = false;
            // GetComponent<CameraManager>().player2Present = false;
            //Debug.Log("player2" + player2Present);
            //Debug.Log("player1" + player1Present);

            // active le sprite renderer
            // change le tag du player avec la marionette
            // anim ((invoc) 1sec) + effets speciaux
            // Coroutine
            // levite legerement puis tombe sur le sol
            // enabled playerF rigidbody2D

              marionettedispo = true;


            print("up arrow key is held down");
        }
        //switch perso
        if (Input.GetKey("e") || (manaDispo < 0))

        {

            //PlayerM.gameObject.GetComponent<DeplacementBasic>().enabled = true;
            //PlayerF.gameObject.GetComponent<DeplacementBasic>().enabled = false;

            //Image assis atteint
            //De ne pas desactiver daeja 
            //Donc prendre des degats 
            // Borner la cam (A faire)
            //Recast player 1 player 2 
            // si depasse certaines distance bloque 

            // Ajout ennemi a fon avec interaction collision = dead + anim attaque ennemi

            //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            PlayerM.gameObject.SetActive(false);
            //PlayerF.gameObject.SetActive(true);

            marionettedispo = false;
            //GetComponent<CameraManager>().player1Present = true;
            // GetComponent<CameraManager>().player2Present = true;

            //Debug.Log("player2"+player2Present);
            //Debug.Log("player1"+player1Present);



            // Rechanger player tag
            // Anim
            // Destory marionnette
            // 
            print("down arrow key is held down");
        }
        if(!marionettedispo)
        {
            manaDispo -= 0.01f;
        }
    }
}
