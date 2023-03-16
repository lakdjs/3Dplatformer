using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacals : MonoBehaviour
{
    [SerializeField] private float _strength;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        var rigidBody = hit.collider.attachedRigidbody;

        if (rigidBody != null)
        {
            var forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();

            rigidBody.AddForceAtPosition(forceDirection * _strength, transform.position, ForceMode.Impulse);


        }
    }
}
