using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuQuit : MonoBehaviour
{
    public void StartMenu(string BacktoMenu)
    {
        SceneManager.LoadScene(BacktoMenu);
    }
}