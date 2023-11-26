using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : weaponBase
{
    [SerializeField] private Rigidbody[] projectile;
    [SerializeField] private float force;
    
    protected override void Attack(float chargePercent)
    {
        int option = 0;
        switch (chargePercent)
        {
            case <0.2f:
                break;
            case <0.5f:
                option = 1;
                break;
            default:
                option = 2;
                break;
        }

        Rigidbody spawnedProjectile = Instantiate(projectile[option], transform.position, transform.rotation);
                    
        spawnedProjectile.AddForce(force*transform.forward, ForceMode.Impulse);
                    
                    
        
        print("bang + " + chargePercent.ToString());
    }
}
