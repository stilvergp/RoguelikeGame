using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeController : WeaponController
{
    protected override void Start()
    {
        base.Start();
    }
    
    protected override void Attack()
    {
        base.Attack();
        GameObject spawnedBlade = Instantiate(weaponData.Prefab);
        spawnedBlade.transform.position = transform.position;
        spawnedBlade.transform.parent = transform;
    }
}
