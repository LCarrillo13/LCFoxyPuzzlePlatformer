using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CRTFilterCustomSetting : MonoBehaviour
{
    [SerializeField]
    private GameObject filterPostProcess;


    public void SetFilter()
    {
        if (!filterPostProcess.activeInHierarchy)
        {
            filterPostProcess.SetActive(true);
        }
        else
        {
            filterPostProcess.SetActive(false);
        }
    }
}
