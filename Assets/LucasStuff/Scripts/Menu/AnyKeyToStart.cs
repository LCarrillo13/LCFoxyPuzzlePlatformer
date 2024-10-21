using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnyKeyToStart : MonoBehaviour
{


   private bool keyPressed = false;
   [SerializeField]
   private string sceneName = "MainMenu";
   public void Update()
   {
       if (Input.anyKey && !keyPressed)
       {
           keyPressed = true;
           UnityEngine.SceneManagement.SceneManager.LoadScene(sceneName);
       }
      
   }    
}
