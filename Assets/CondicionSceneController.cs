using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CondicionSceneController : MonoBehaviour
{
    public void IrALevel1()
    {
        SceneManager.LoadScene("Level1"); // Cargar la escena "Level2"
    }


    public void Win()
    {
        SceneManager.LoadScene("Level2"); // Cargar la escena "Level2"
    }
}

