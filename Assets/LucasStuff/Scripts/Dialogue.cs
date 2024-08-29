using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField]
    private GameObject playerDialogue;
    private TextMeshPro playerText;
    [SerializeField]
    private GameObject npcDialogue;
    [SerializeField]
    public string[] lines;
    public float textSpeed;
// vars 
    private int index;
    private bool isPlayerTalking;
   
    
    void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        foreach (char c in lines[index].ToCharArray())
        {
            playerText.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }
}
