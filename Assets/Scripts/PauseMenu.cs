using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    //public KeyCode pauseKey;
    public static bool isPaused;
    [SerializeField] float time;
    [SerializeField] float timeStore;
    bool touchapp = false;
    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
        timeStore = time;
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }
    public void GoToMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuDemarrage");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    // Update is called once per frame
    void Update()
    {
        Debug.Log("Est en pause est "+isPaused);
        if (time > 0)
        {
            time -= Time.deltaTime;
        }
        else
        {
            if (Input.GetKey("h"))
            {
                touchapp = true;
                Debug.Log("app");
            }
            if (touchapp)
            {
                Debug.Log("isPaused");
                //isPaused = !isPaused;
            }
            //if(Input.GetKey("h"))
            if (touchapp)
            {
                    ResumeGame();
                    Debug.Log("jeu repris");
                    touchapp =false;
                    //isPaused = true;
                    time = timeStore;
            }
            else
            {
                    Debug.Log("jeu arreter");
                    PauseGame();
                    touchapp = false;
                    //isPaused = false;
                    time = timeStore;
            }
               // Debug.Log("isPaused");
                //if(isPaused)
                
                    
            
        }
        
    }


}
/*
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Alpha");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
  */
