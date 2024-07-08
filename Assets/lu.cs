using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class lu : MonoBehaviour
{
    public Light2D playerLight;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerLight.intensity = 0;
    }
}
