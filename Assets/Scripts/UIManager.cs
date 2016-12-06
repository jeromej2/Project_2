using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Animator dialog;
    public void StartGame()
    {
        Application.LoadLevel("main");
    }

    public void OpenSettings()
    {
        dialog.SetBool("isHidden", false);
    }

    public void CloseSettings()
    { 
        dialog.SetBool("isHidden", true);
    }
}
