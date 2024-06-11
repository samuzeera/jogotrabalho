using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDeJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    [SerializeField] public GameObject creditosMenu;

    private void Start()
    {
        // Verifica se creditosMenu é nulo e exibe um aviso no console
        if (creditosMenu == null)
        {
            Debug.LogWarning("O objeto do creditosMenu não foi atribuído no Inspector do Unity.");
        }
    }

    public void Jogar()
    {
        SceneManager.LoadScene(nomeDoLevelDeJogo);
    }

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
        if (creditosMenu != null)
        {
            creditosMenu.SetActive(false);
        }
    }

    public void FechaOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
        if (creditosMenu != null)
        {
            creditosMenu.SetActive(false);
        }
    }

    public void AbrirCreditos()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(false);
        if (creditosMenu != null)
        {
            creditosMenu.SetActive(true);
        }
    }
}
