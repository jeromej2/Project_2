using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Animator levelOne;
    public Animator levelTwo;
    public GameObject[] pauseObjects;

    public void Start()
    {
        Time.timeScale = 1;
        pauseObjects = GameObject.FindGameObjectsWithTag("ShowOnPause");
        hidePaused();
    }

    public void Update()
    {
        //uses the p button to pause and unpause the game
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                showPaused();
            }
            else if (Time.timeScale == 0)
            {
                Debug.Log("high");
                Time.timeScale = 1;
                hidePaused();
            }
        }
    }
    //controls the pausing of the scene
    public void pauseControl()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            showPaused();
        }
        else if (Time.timeScale == 0)
        {
            Time.timeScale = 1;
            hidePaused();
        }
    }

    //shows objects with ShowOnPause tag
    public void showPaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(true);
        }
    }
    //Reloads the Level
    public void Reload()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    //hides objects with ShowOnPause tag
    public void hidePaused()
    {
        foreach (GameObject g in pauseObjects)
        {
            g.SetActive(false);
        }
    }
    //loads inputted level
    public void LoadLevel(string level)
    {
        Application.LoadLevel(level);
    }
    public void StartGame()
    {
        Application.LoadLevel("main");
    }

    public void OpenSettings()
    {
        levelOne.SetBool("isHidden", true);
        levelTwo.SetBool("isHidden", true);
    }

    public void CloseSettings()
    { 
        levelOne.SetBool("isHidden", false);
        levelTwo.SetBool("isHidden", false); 
    }
}
