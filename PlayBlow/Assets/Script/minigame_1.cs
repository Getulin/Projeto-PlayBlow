using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.ParticleSystem;
using UnityEngine.SceneManagement;

public class minigame_1 : MonoBehaviour
{
    public GameObject barcoInicial;
    public GameObject barcoFinal;

    public float speed = 5.0f;
    private float forwardInput;
    public GameObject animacao;
    public GameObject animacaoFinal;
    private bool isStarted = false;
    private bool isEnded = false;

    public Animator animatorA;

    public float velocidade;
    public Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        animatorA = animatorA.GetComponent<Animator>();

        isStarted = false;
        isEnded = false;
        animacao.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        

        if(isStarted == true)
        {
            rb = GetComponent<Rigidbody>();
            Vector3 vel = rb.velocity;
            if (vel.magnitude > 0)
            {

            }
            else
            {

                animatorA.SetTrigger("afundar");
                barcoFinal.SetActive(true);
                barcoInicial.SetActive(false);
                animacaoFinal.SetActive(true);
                isEnded = true;

                StartCoroutine(endRoutine());
                

            }
        }
 
    
        if (isEnded == false)
        {
            forwardInput = Input.GetAxis("Horizontal");

            if (Input.GetKey(KeyCode.A))
            {
                StartCoroutine(startRoutine());
                animacao.SetActive(true);
                transform.Translate(Vector3.right * Time.deltaTime * speed * forwardInput);

            }
            else
            {
                animacao.SetActive(false);
            }

        }
        


    }

    public IEnumerator startRoutine()
    {
        yield return new WaitForSeconds(2);
        isStarted = true;

    }

    public IEnumerator endRoutine()
    {
        yield return new WaitForSeconds(2);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }

}
