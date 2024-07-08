using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectarsalto : MonoBehaviour
{

    public static bool suelo;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        suelo = true;            //Script creado para detectar suelo
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        suelo = false;  
    }
  
       
    
}
