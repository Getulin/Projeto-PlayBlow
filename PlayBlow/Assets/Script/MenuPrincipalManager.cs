using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipalManager : MonoBehaviour
{

   [SerializeField] private GameObject painelMenuInicial;
   [SerializeField] private GameObject painelOpcoes;
   [SerializeField] private GameObject painelLogin;

    public void Jogar()
    {
        SceneManager.LoadScene(1);
    }

    public void AbrirLogin()
    {
        painelMenuInicial.SetActive(false);
        painelLogin.SetActive(true);
    }

    public void FecharLogin()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void AbrirOpcoes()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }

    public void FecharOpcoes()
    {
        painelOpcoes.SetActive(false);
        painelMenuInicial.SetActive(true);
    }

    public void SairJogo()
    {
        Debug.Log("Sair do Jogo");
        Application.Quit();
    }
}
