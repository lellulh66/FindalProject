using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class Movables : MonoBehaviour
{
    [SerializeField] private CharacterController CC;
    private float pushPower = 4;
    void OnContollerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody body = hit.collider.attachedRigidbody;
        if (body == null || body.isKinematic) 
            return;
        if(hit.moveDirection.y < -0.3f)
            return;
        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z);
        Vector3 collisionPoint = hit.point;
        body.AddForceAtPosition(pushDir * pushPower, collisionPoint, ForceMode.Impulse);
    }
}
