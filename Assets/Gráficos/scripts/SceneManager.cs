using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    void Start()
    {
        // Carrega a primeira cena da lista
        LoadNextScene();
    }

    void LoadNextScene()
    {
        // Obtém o índice da cena atual
        int currentIndex = SceneManager.GetActiveScene().buildIndex;

        // Verifica se há outra cena na lista
        if (currentIndex < SceneManager.sceneCountInBuildSettings - 1)
        {
            // Carrega a próxima cena
            SceneManager.LoadScene(currentIndex + 1);
        }
        else
        {
            Debug.Log("Todas as cenas foram carregadas.");
            // Aqui você pode fazer algo após carregar todas as cenas, como iniciar o jogo
        }
    }
}
