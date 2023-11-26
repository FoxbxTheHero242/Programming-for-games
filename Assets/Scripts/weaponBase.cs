using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public abstract class weaponBase : MonoBehaviour
{

    [SerializeField] protected float timeBetweenAttatcks;
    [SerializeField] protected float chargeUpTime;
    [SerializeField, Range(0,1)]  protected float minChargePercent;
    [SerializeField] private bool isFullyAutomatic;

    private Coroutine currentFireTimer;

    private bool isOnCooldown;
    
    private WaitForSeconds myCooldownTimer;
    

    private void Awake()
    {
        myCooldownTimer = new WaitForSeconds(timeBetweenAttatcks);
    }

    public void StartFiring()
    {
        
    }

    public void StopFiring()
    {
        
    }

    protected virtual void TryAttack(float percent)
    {
        if (!CanAttack(percent)) return;
        Attack(percent);
        
    }

    protected virtual bool CanAttack(float percent)
    {
        return !isOnCooldown && minChargePercent<=percent;//can return 2 bools at once
    }

    protected abstract void Attack(float chargePercent);

    private IEnumerator ReFireTimer()
    {
        return null;
    }

    private IEnumerator CooldownTime()
    {
        isOnCooldown = true;
        yield return myCooldownTimer;
        isOnCooldown = false;
    }
    


}
