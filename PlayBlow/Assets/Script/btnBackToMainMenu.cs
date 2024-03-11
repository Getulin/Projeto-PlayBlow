using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnBackToMainMenu : MonoBehaviour
{
    public Camera mainCamera;


    public CanvasGroup miniGameCanvas_1;
    public CanvasGroup mainMenu;

    private bool shouldZoomOut;

    public float zoomSmooth = 0.25f;
    public float zoomSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        shouldZoomOut = false;
        gameObject.GetComponent<Button>().onClick.AddListener(backToMainMenu);

    }

    // Update is called once per frame
    void Update()
    {
        if (shouldZoomOut == true)
        {
            ZoomOut();
        }

    }
    void backToMainMenu()
    {
        mainCamera.transform.position = new Vector3(-39.2f, 51.8f, -41f);
        if (shouldZoomOut != true)
        {
            shouldZoomOut = true;
        }
    }

    void ZoomOut()
    {
        if (mainCamera.orthographicSize < 26.5f)
        {
            mainCamera.orthographicSize = Mathf.SmoothDamp(mainCamera.orthographicSize, 27.5f, ref zoomSpeed, zoomSmooth);

            if(miniGameCanvas_1.alpha >= 0)
            {
                miniGameCanvas_1.alpha -= Time.deltaTime * 2;
                mainMenu.alpha += Time.deltaTime * 2;
            }
        }
        else
        {
            shouldZoomOut = false;
}

    }
}
