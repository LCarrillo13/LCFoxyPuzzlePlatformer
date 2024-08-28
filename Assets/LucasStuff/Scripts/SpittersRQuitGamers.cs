using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpittersRQuitGamers : MonoBehaviour
{
    public void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
            Application.Quit();
#endif
    }
}
