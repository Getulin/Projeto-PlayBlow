using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class zoomCamera : MonoBehaviour
{
    public Camera mainCamera;

    public CanvasGroup miniGameCanvas_1;
    public CanvasGroup mainMenu;

    public float zoom;
    public float zoomSmooth = 0.25f;
    public float zoomSpeed = 0f;


    private bool shouldZoomIn;




    // Start is called before the first frame update
    void Start()
    {
        shouldZoomIn = false;
        //gameObject.GetComponent<Button>().onClick.AddListener(goToMiniGame1);


    }

    // Update is called once per frame
    void Update()
    {
        if(shouldZoomIn == true)
        {
            ZoomIn();
        }
        
    }

    public void goToMiniGame1()
    {
        mainCamera.transform.position = new Vector3(-30.03f, 48.8f, -43.6f);
        if (shouldZoomIn != true)
        {
            shouldZoomIn = true;
        }
    }
    public void goToMiniGame2()
    {
        mainCamera.transform.position = new Vector3(-74.4f, 45.4f, -45.9f);
        if (shouldZoomIn != true)
        {
            shouldZoomIn = true;
        }
    }

    public void ZoomIn()
    {
        if (mainCamera.orthographicSize > 3f)
        {
            mainCamera.orthographicSize = Mathf.SmoothDamp(mainCamera.orthographicSize, 2f, ref zoomSpeed, zoomSmooth);

            if (mainMenu.alpha <= 1)
            {
                mainMenu.alpha -= Time.deltaTime * 2;
                miniGameCanvas_1.alpha += Time.deltaTime * 2;
            }
        }
        else
        {
            shouldZoomIn = false;
}
    }
}
