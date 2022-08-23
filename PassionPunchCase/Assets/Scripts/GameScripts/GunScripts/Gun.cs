using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    private void OnEnable()
    {
        GameManager.OnTriggerPulled += GameManager_OnTriggerPulled;
        GameManager.OnTriggerBreak += GameManager_OnTriggerBreak;
    }

    private void GameManager_OnTriggerBreak()
    {
        StopCoroutine(AutomaticFire());
        _isTriggerBreaked = true;
        
    }

    private void GameManager_OnTriggerPulled()
    {
        
        _isTriggerBreaked = false;
        AutoFire();
        
    }

  
    private void OnDisable()
    {
        
        GameManager.OnTriggerPulled -= GameManager_OnTriggerPulled;
        GameManager.OnTriggerBreak -= GameManager_OnTriggerBreak;
    }

   
    [SerializeField] private GunScriptAble _gunStats;
    private int _firedBulletCount;
    private bool _isTriggerBreaked;
    private bool _canFire;
    [SerializeField] private GameObject _bullet;

    [SerializeField] private Transform _bulletSpawnPoint;

    private void Start()
    {
        _canFire = true;
    }

    private void AutoFire()
    {
        if (_canFire)
        {
            StartCoroutine(AutomaticFire());
            _canFire = false;
        }
        
        
        
    }


    IEnumerator  AutomaticFire()
    {
        if (!_isTriggerBreaked)
        {
           
            GameManager.Instance.GunFiring(_firedBulletCount);
            for (int i = 0; i < 4; i++)
            {
                _firedBulletCount++;
                Instantiate(_bullet, _bulletSpawnPoint.position, Quaternion.identity);
            }
            
            
        }
        yield return new WaitForSecondsRealtime(_gunStats.rateOfFire);
        GameManager.Instance.GunFired();
        _canFire = true;
       
        
        
        
       
    }

}
