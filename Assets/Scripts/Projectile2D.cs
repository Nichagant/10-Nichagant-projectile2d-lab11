using System;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Transform shootPoint;
    [SerializeField] GameObject target; //target sprite
    [SerializeField] private Rigidbody2D bulletPrefab;

    void Update()
    {
        throw new NotImplementedException();
    }
}
