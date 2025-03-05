using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour
{
    // Método para comenzar el juego
    public void StartGame()
    {
        // Cambia a la escena del juego, por ejemplo, "GameScene"
        SceneManager.LoadScene("VRTestNaveBacked");
    }

    // Método para salir del juego
    public void QuitGame()
    {
        // Salir de la aplicación
        Application.Quit();
        Debug.Log("Saliendo del juego");
    }

    public void MainMenu()
    {
        // Cambia a la escena del juego, por ejemplo, "GameScene"
        SceneManager.LoadScene("MainMenu");
    }
}
