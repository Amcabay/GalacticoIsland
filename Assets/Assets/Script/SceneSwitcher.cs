using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{

    /*public void OpenScene (int index)
    {
        SceneManager.LoadScene(index);
    }*/

    public void LoadGame()
    {
        Application.LoadLevel("NeoWorld_1");
    }

    public void LoadOption()
    {
        Application.LoadLevel("Option");
    }

    public void NoExit()
    {
        Application.LoadLevel("Main Menu");
    }

    public void YesExit()
    {
        Application.Quit();
        Debug.Log("Metuo Co");
    }

    public void LoadExitPopup()
    {
        Application.LoadLevel("Exit");
    }


}
