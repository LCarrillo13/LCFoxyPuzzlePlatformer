using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeaponClass : MonoBehaviour
{
    [Header("Global Weapon Variables")]
    [SerializeField]
    protected float health;
    [SerializeField]
    protected float attackDistance;
    [SerializeField]
    protected bool isPlayerHolding;
    protected virtual void Attack()
    {
        Debug.Log("Attacking");
    }
}
