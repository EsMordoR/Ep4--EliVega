using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class vidajugador : MonoBehaviour
{
    public GameObject[] corazones;
    public int cantidaddevida;
    public void TomarDamage(int damage)
    {
        cantidaddevida -= damage;
        if (cantidaddevida <= 0)
        {
            
            Destroy(corazones[1].gameObject);
            Destroy(gameObject);
            SceneManager.LoadScene("Loser");                             //Metodo de vida de personaje
                                                                         //Cada vez que le hagan daño pierde un corazon
           


        }
        if (cantidaddevida <=1)
        {
            Destroy(corazones[0].gameObject);
            
            
        }

    }

    

    }