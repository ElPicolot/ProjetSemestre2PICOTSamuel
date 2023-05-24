using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummonCam : MonoBehaviour
{
    [SerializeField] GameObject frere;

    bool isSwitchAvailable = false;
    [SerializeField] bool marionettedispo ;
    int timeMarionnette = 5;
    float manaMax = 200;
    float manaDispo;
    [SerializeField] public bool present;
    [SerializeField] float time;
    [SerializeField] float timeStore;
    [SerializeField] Sprite invisiblefrere;
    [SerializeField] Sprite visiblefrere;
    // Start is called before the first frame update
    void Start()
    {
        isSwitchAvailable = true;
        manaDispo = manaMax;
        timeStore = time;
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            if (Input.GetKey("z") && present)

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
                //frere.gameObject.SetActive(false);
                frere.GetComponent<SpriteRenderer>().sprite = invisiblefrere;
                //PlayerF.gameObject.SetActive(true);

                marionettedispo = true;
            //GetComponent<CameraManager>().player1Present = true;
            // GetComponent<CameraManager>().player2Present = true;

            //Debug.Log("player2"+player2Present);
            //Debug.Log("player1"+player1Present);
                present = false;
                time = timeStore;


                // Rechanger player tag
                // Anim
                // Destory marionnette
                // 
                print("down arrow key is held down");
            }
            else if (Input.GetKey("z") && !present)
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
                //frere.gameObject.SetActive(true);
                frere.GetComponent<SpriteRenderer>().sprite = visiblefrere;

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
                present = true;
                marionettedispo = true;
                time = timeStore;


                print("up arrow key is held down");
            }
        }
    }
}
