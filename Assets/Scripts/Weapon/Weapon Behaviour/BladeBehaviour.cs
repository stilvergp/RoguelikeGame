using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BladeBehaviour : MeleeWeaponBehaviour
{
    public float rotationSpeed = 100f;
    
    protected override void Start()
    {
        base.Start();
    }

    void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
    }
}
