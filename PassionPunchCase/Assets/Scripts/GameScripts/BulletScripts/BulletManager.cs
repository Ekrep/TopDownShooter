using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public static BulletManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    private void OnEnable()
    {
        GameManager.OnAddedBigBullet += GameManager_OnAddedBigBullet;
        GameManager.OnRemovedBigBullet += GameManager_OnRemovedBigBullet;
        GameManager.OnAddedRedBullet += GameManager_OnAddedRedBullet;
        GameManager.OnRemovedRedBullet += GameManager_OnRemovedRedBullet;
    }

    private void GameManager_OnRemovedRedBullet()
    {
        BulletFireFunction -= AddRedBullet;
        BulletFireFunction += RemoveRedBullet;
    }

    private void GameManager_OnAddedRedBullet()
    {
        BulletFireFunction += AddRedBullet;
        BulletFireFunction -= RemoveRedBullet;
    }

    private void GameManager_OnRemovedBigBullet()
    {
        BulletFireFunction -= AddBigBullet;
        BulletFireFunction += RemoveBigBullet;
    }

    private void GameManager_OnAddedBigBullet()
    {
        BulletFireFunction += AddBigBullet;
        BulletFireFunction -= RemoveBigBullet;
    }

    private void OnDisable()
    {
        GameManager.OnAddedBigBullet -= GameManager_OnAddedBigBullet;
        GameManager.OnRemovedBigBullet -= GameManager_OnRemovedBigBullet;
    }

    public delegate void BulletFunction(GameObject go);
    public BulletFunction BulletFireFunction;


    private void AddBigBullet(GameObject go)
    {
       go.transform.localScale = gameObject.transform.localScale *1.5f;
    }
    private void AddRedBullet(GameObject go)
    {
        go.GetComponent<Bullet>().mat.color = Color.red;
    }
    private void RemoveRedBullet(GameObject go)
    {
        go.GetComponent<Bullet>().mat.color = Color.gray;
    }
    private void RemoveBigBullet(GameObject go)
    {
        go.transform.localScale = gameObject.transform.localScale / 1.5f;
    }


}
