
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausaJogo : MonoBehaviour
{
  public GameObject painel_do_menu;
  public bool jogoPausado;


   // Start is called before the first frame update
   void Start()
   {
        Time.timeScale = 1f;
        jogoPausado = false;
        painel_do_menu.SetActive(false);
   }

   // Update is called once per frame
   void Update()
   {
       if(Input.GetKeyDown(KeyCode.Escape)) {
           PausarJogo();
       }
   }

   private void PausarJogo(){
       // estiver funcionando -> pause
       if (jogoPausado == false) 
       {
           Time.timeScale = 0f;
           painel_do_menu.SetActive(true); //ainda nao esta funcionando
           jogoPausado = true;
       }


       // se estiver pausado -> funcione
       else{
            Time.timeScale = 1f;
            painel_do_menu.SetActive(false);
            jogoPausado = false;
       }


   }
}
    