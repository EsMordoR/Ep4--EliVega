using UnityEngine;
using UnityEngine.SceneManagement;

public class Vacio : MonoBehaviour
{
    

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
            SceneManager.LoadScene("Loser");


        }
    }
}
