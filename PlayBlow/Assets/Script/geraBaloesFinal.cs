using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class geraBaloesFinal : MonoBehaviour
{
    public GameObject baloes;
    public GameObject ponte;
    public GameObject luz;
    public GameObject barco;
    public GameObject animacaoInicial;
    public GameObject animacaoFinal;
    //public GameObject telaFinal;

    public GameManagerScript gameManager;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (ponte.GetComponent<Collider>().enabled == false)
        {
            gameManager.gameOver();
            barco.GetComponent<minigame_1>().enabled = false;
            baloes.SetActive(true);
            animacaoInicial.SetActive(false);
            animacaoFinal.SetActive(true);
        }

    }
}
