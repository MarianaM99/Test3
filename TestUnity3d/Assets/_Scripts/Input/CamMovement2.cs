using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement2 : MonoBehaviour
{
    public Transform target;

    [SerializeField] private Vector3 offset;
    [SerializeField] private float followSpeed;

 

    // movimientos de camara 
    void LateUpdate()
    {
        FollowTarget();

    }
    // Camara persigue al objetivo
    public void FollowTarget()
    {
        if(target != null)
        {
            var targetPos = target.position + offset;
            transform.position = targetPos;

        }
    }
}
