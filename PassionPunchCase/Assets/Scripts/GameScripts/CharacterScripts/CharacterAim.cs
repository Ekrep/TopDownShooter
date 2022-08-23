using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAim : MonoBehaviour
{
    [SerializeField] private LayerMask _layer;
    private Vector3 _hitPos;

    private void Update()
    {
        Aiming();
    }
    private void Aiming()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity,_layer))
        {
             _hitPos = hit.point;
        }
        Vector3 directon = _hitPos - transform.position;
        directon.y = 0;

        transform.forward = directon;
    }
}
