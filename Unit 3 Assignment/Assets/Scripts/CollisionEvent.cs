using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider))]

public class CollisionEvent : MonoBehaviour
{
    public UnityEvent OnCollide;

    private void OnCollisionEnter(Collision collision)
    {
        OnCollide.Invoke();
    }
}
