using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject barco;
   


    private Vector3 offset = new Vector3(0f, 0f, 0f);
    [SerializeField] public float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] public Camera cam;

    [SerializeField] private Transform startTarget;
    [SerializeField] private Transform target;
    [SerializeField] private Transform Finaltarget;

    private bool isStart = true;

    void Start()
    {
        barco.GetComponent<minigame_1>().enabled = false;
        isStart = true;

    }


    private void Update()
    {
        if(isStart == true)
        {
            StartCoroutine(startRoutine());
        }
        else
        {
            
            Vector3 targetPosition = target.position + offset;
            cam.transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
            

        }

    }


    public IEnumerator startRoutine()
    {
        cam.transform.LookAt(startTarget);
        yield return new WaitForSeconds(2);
        

        isStart = false;
        barco.GetComponent<minigame_1>().enabled = true;
     

    }


    public void gameOver()
    {
        StartCoroutine(finalDelay());

    }

    public IEnumerator finalDelay()
    {
        yield return new WaitForSeconds(1);

        
        Vector3 targetPosition = target.position + offset;
        cam.transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);

        gameOverUI.SetActive(true);

        target = Finaltarget;

    }

}
