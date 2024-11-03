using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Pickup
{
    public int healthToRestore;

    public override void Collect()
    {
        if(hasBeenCollected)
        {
            return;
        }
        else if (!hasBeenCollected)
        {
            base.Collect();
        }
        
        PlayerStats player = FindObjectOfType<PlayerStats>();
        player.RestoreHealth(healthToRestore);
    }
}
