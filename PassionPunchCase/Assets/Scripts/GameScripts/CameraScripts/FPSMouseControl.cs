using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMouseControl : MonoBehaviour
{
    //[SerializeField]private FPSMouseControlScriptable _fpsSettings;

    //[SerializeField] private Transform _player;


    //private float _rotationOnX;

    private Vector3 _distance;
    [SerializeField] private GameObject _followedbyCamObject;
    void Start()
    {
        
        _distance = _followedbyCamObject.transform.position - gameObject.transform.position;
    }

    
    void Update()
    {
        //FPSControl();
        gameObject.transform.position = _followedbyCamObject.transform.position - _distance;
    }

    /*private void FPSControl()
    {
        float xposMouse = Input.GetAxis("Mouse X") * _fpsSettings.mouseSensivity*10f * Time.deltaTime;
        float yposMouse = Input.GetAxis("Mouse Y") * _fpsSettings.mouseSensivity *10f* Time.deltaTime;

        _rotationOnX -= yposMouse;
        _rotationOnX = Mathf.Clamp(_rotationOnX, -90f, 90f);

        transform.localRotation = Quaternion.Euler(_rotationOnX, 0f, 0f);
        _player.Rotate(Vector3.up * xposMouse);

    }*/

}
