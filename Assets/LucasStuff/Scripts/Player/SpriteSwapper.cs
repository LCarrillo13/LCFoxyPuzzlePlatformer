using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpriteSwapper : MonoBehaviour
{

    public GameObject itemOne;
    public GameObject itemTwo;
    [SerializeField]
    private Image activeSprite;
    
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Swap();
        }
    }

  
    void Swap()
    {
        if (itemOne.activeInHierarchy)
        {
            itemOne.SetActive(false);
            itemTwo.SetActive(true);
        }
        else
        {
            itemOne.SetActive(true);
            itemTwo.SetActive(false);
        }
    }
}
