using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    // Menu objects
    public GameObject menu;
    public GameObject optionsMenuPanel;
    public GameObject mainMenuPanel;
    public GameObject creditsPanel;
    public GameObject controlsPanel;
    
    
    
    
    public void ChangeMenu(string menuName)
    {
        menu.SetActive(false);
        if (menuName == "Main")
        { 
            mainMenuPanel.SetActive(true);
        }
        else if (menuName == "Options")
        {
            optionsMenuPanel.SetActive(true);
        }
        else if (menuName == "Controls")
        {
            controlsPanel.SetActive(true);
        }
        else if (menuName == "Credits")
        {
            creditsPanel.SetActive(true);
        }
    }
}
