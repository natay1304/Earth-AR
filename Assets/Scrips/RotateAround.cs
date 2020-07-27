using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [SerializeField]
    private Transform _rotationPoint;
    [SerializeField]
    private Transform _rotationObject;

    public float speedRotation = 30f;

    void Update()
    {
        ToRotateAround();
    }

    private void ToRotateAround()
    {
        _rotationObject.RotateAround(_rotationPoint.transform.position, Vector3.up, speedRotation * Time.deltaTime);
    }
}
