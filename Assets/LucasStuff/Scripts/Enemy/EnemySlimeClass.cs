using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemySlimeClass : EnemyBaseClass
{
    // Start is called before the first frame update
    protected override void Attack()
    {
        base.Attack();
    }

    protected override void Move()
    {
        base.Move();
    }

    protected override void TakeDamage()
    {
        base.TakeDamage();
    }

    protected override void Die()
    {
        base.Die();
    }

    private void Start()
    {
        Attack();
        Move();
        TakeDamage();
        Die();
        TriggerBossFight();
    }
}
