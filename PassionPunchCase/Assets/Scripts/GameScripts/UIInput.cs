using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UIInput : MonoBehaviour
{
    [SerializeField] private Button _addBigBullet;
    [SerializeField] private Button _removeBigBullet;
    [SerializeField] private Button _addRedBullet;
    [SerializeField] private Button _removeRedBullet;


    public void AddBigBullet()
    {
        GameManager.Instance.AddedBigBullet();
        _addBigBullet.interactable = false;
        _removeBigBullet.interactable = true;
    }
    public void RemoveBigBullet()
    {
        GameManager.Instance.RemovedBigBullet();
        _addBigBullet.interactable = true;
        _removeBigBullet.interactable = false;


    }
    public void AddRedBullet()
    {
        GameManager.Instance.AddedRedBullet();
        _addRedBullet.interactable = false;
        _removeRedBullet.interactable = true;
    }
    public void RemoveRedBullet()
    {
        GameManager.Instance.RemovedRedBullet();
        _addRedBullet.interactable = true;
        _removeRedBullet.interactable = false;
    }
}
