using UnityEngine;
using UnityEngine.UI;

public class barraProgresso : MonoBehaviour
{
    [SerializeField] GameObject playerGO;
    [SerializeField] GameObject finishGO;

    Image progressBar;
    float maxDistance;

    void Start()
    {
        progressBar = GetComponent<Image>();
        maxDistance = finishGO.transform.position.x;
    }

    void Update()
    {
        // Garante que a barra de progresso seja inicializada apenas uma vez
        if (progressBar.fillAmount <= 0)
        {
            progressBar.fillAmount = 1 - playerGO.transform.position.x / maxDistance;
        }

        // Atualiza dinamicamente a barra de progresso durante o jogo
        if (progressBar.fillAmount > 0)
        {
            progressBar.fillAmount = 1 - playerGO.transform.position.x / maxDistance;
            Debug.Log(playerGO.transform.position.x / maxDistance);
        }
    }
}
