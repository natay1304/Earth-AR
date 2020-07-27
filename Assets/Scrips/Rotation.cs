using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Rotation : MonoBehaviour
{
    [SerializeField]
    private Transform _pointForRotation;
    private TouchRotation _myTouch;
    public float _speed = 50f;
    private bool _stoprotate = false;

    private void Update()
    {
        ToRotate();
    }

    private void ToRotate()
    {
        transform.RotateAround(_pointForRotation.transform.position, _pointForRotation.transform.up, _speed * Time.deltaTime);
    }
}
