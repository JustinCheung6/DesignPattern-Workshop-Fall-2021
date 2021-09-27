using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : HealthStrategy
{
    public override void Hurt()
    {
        healthPoints -= 1;

        if(healthPoints <= 0)
        {
            MenuManager.s.GameOver();
        }
    }
}
