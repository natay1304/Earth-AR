using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightsIntencity : MonoBehaviour
{
    public Material earthMaterial;     

    public void ToChangeLightsIntencity(float intencity)
    {
        earthMaterial.SetFloat("_NightTransitionVariable", intencity);   
    }
}
