using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.Universal;


public class luz : MonoBehaviour

{
    public GameObject vela;
    public Light2D freeformLight;
    public Light2D playerLight;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            playerLight.intensity = 0;
            for (float i = 0f; i < 1f; i += 0.1f)
            {
                StartCoroutine(encendidoProgresivo());
            }
            Destroy(gameObject, 1f);
        }
    }

    private IEnumerator encendidoProgresivo()
    {
        for (float i = 0f; i < 1f; i += 0.1f)
        {
            freeformLight.intensity = i;
            yield return new WaitForSeconds(0.1f);
        }
    }
}
