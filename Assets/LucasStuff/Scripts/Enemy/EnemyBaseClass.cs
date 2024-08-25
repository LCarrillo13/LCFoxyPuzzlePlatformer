using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EnemyBaseClass : MonoBehaviour
{
    
    [Header("Global Enemy Variables")]
    [SerializeField]
    protected float health;
    [SerializeField]
    protected float attackDistance;
    [SerializeField] 
    protected bool isBoss;
  
    
    /// <summary>
    /// Abstract Enemy Attack function
    /// </summary>
    protected virtual void Attack()
    {
        Debug.Log("Attacking");
        
    }
    
    /// <summary>
    /// Abstract Enemy Movement Function
    /// </summary>
    protected virtual void Move()
    {
        Debug.Log("Moving");
    }
    
    /// <summary>
    /// Abstract enemy Taking damage function
    /// </summary>
    ///
     protected virtual void TakeDamage()
    {
        Debug.Log("Taking Damage");
    }
    
    /// <summary>
    /// Abstract enemy dying function
    /// </summary>
    protected virtual void Die()
    {
        Debug.Log("Dying");
    }
    
    /// <summary>
    /// funtion to check if boss or not and trigger the boss fight music and scene if so
    /// </summary>
    protected virtual void TriggerBossFight()
    {
        if (isBoss)
        {
            Debug.Log("Triggering Boss Fight");
            // TODO add music and boss visual interactions
        }
        else
            return;
    }   
}
