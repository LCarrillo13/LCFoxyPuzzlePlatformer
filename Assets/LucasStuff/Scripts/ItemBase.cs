using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ItemBase : MonoBehaviour
{
    [Header("Global Item Variables")] [SerializeField]
    protected int itemID;
    
    protected virtual void StatusEffects()
    {
        
    }
}
