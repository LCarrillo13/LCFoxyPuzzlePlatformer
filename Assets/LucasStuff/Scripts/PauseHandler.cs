using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseHandler : MonoBehaviour
{

    public GameObject pausemenu;
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    public void Pause()
    {
        
        if (!isPaused)
        {
            Time.timeScale = 0;
            pausemenu.SetActive(true);
            isPaused = true;
        }
        else
        {
            Time.timeScale = 1;
            pausemenu.SetActive(false);
            isPaused = false;
        }
    }
}
