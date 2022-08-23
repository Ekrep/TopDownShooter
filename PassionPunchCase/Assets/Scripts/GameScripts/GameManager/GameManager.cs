using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;


    private void Awake()
    {
        if (Instance==null)
        {
            Instance = this;
        }
    }

    public static event Action OnTriggerPulled;

    public static event Action<int> OnGunFiring;

    public static event Action OnTriggerBreak;

    public static event Action OnGunFired;

    public static event Action OnAddedBigBullet;
    public static event Action OnRemovedBigBullet;

    public static event Action OnAddedRedBullet;
    public static event Action OnRemovedRedBullet;

    public void TriggerPulled()
    {
        if (OnTriggerPulled!=null)
        {
            OnTriggerPulled();
        }
    }
    public void TriggerBreak()
    {
        if (OnTriggerBreak != null)
        {
            OnTriggerBreak();
        }
    }

    public void GunFiring(int bulletCount)
    {
        
        if (OnGunFiring!=null)
        {
            OnGunFiring(bulletCount);
        }
    }
    public void GunFired()
    {
        if (OnGunFired != null)
        {
            OnGunFired();
        }
    }
    public void AddedBigBullet()
    {
        if (OnAddedBigBullet != null)
        {
            OnAddedBigBullet();
        }
    }
    public void RemovedBigBullet()
    {
        if (OnRemovedBigBullet != null)
        {
            OnRemovedBigBullet();
        }
    }
    public void AddedRedBullet()
    {
        if (OnAddedRedBullet != null)
        {
            OnAddedRedBullet();
        }
    }
    public void RemovedRedBullet()
    {
        if (OnRemovedRedBullet != null)
        {
            OnRemovedRedBullet();
        }
    }
}
