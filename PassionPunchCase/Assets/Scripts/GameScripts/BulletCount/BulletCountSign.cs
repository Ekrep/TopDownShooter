using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BulletCountSign : MonoBehaviour
{
    
    private void OnEnable()
    {
        GameManager.OnGunFiring += GameManager_OnGunFiring;
    }

    private void GameManager_OnGunFiring(int firedBullet)
    {
        _bulletCount.text = "Fired Bullets: \n"+firedBullet.ToString();
    }

    private void OnDisable()
    {
        GameManager.OnGunFiring -= GameManager_OnGunFiring;
    }

    [SerializeField]private TextMeshPro _bulletCount;


    private void Start()
    {
        _bulletCount.text = "Fired Bullets:";
    }

}
