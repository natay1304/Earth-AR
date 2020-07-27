using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLightIntencity : MonoBehaviour
{
    private float _intencity = 1f;
    private Light _myLight;

    private void Start()
    {
        _myLight = GetComponent<Light>();
    }

    private void Update()
    {
        _myLight.intensity = _intencity;
    }

    public void ToChangeLight(float newIntencity)
    {
        _intencity = newIntencity / 10f;
    }
}
