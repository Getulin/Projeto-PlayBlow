using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opcoesJump : MonoBehaviour
{
    public Transform box;
    public CanvasGroup background;

    private void OnEnable()
    {
        background.alpha = 0;
        background.LeanAlpha(1, 0.5f);

        box.localPosition = new Vector2(0, -750f);
        box.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;

    }

    // Update is called once per frame
    public void CloseDialog()
    {
        background.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-750f, 0.5f).setEaseOutExpo().setOnComplete(OnComplete);

    }

    void OnComplete()
    {
        gameObject.SetActive(false);
    }
}
