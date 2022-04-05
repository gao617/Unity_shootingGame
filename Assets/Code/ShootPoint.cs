using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootPoint : MonoBehaviour
{
    [SerializeField] private Camera fpsCam;

    void Update()
    {
        Ray ray = fpsCam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out RaycastHit raycastHit))
        {
            transform.position = raycastHit.point;
        }
    }
}
