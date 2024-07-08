using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generar : MonoBehaviour
{

    public GameObject monedaPrefab;
    public Vector3[] posicionesMoneda;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < posicionesMoneda.Length; i++)
        {

            Instantiate(monedaPrefab, posicionesMoneda[i], Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

   
}
