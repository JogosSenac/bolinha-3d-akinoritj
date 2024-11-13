using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AtivadorInGame : MonoBehaviour
{
        private Movimentacao player;
        public GameObject canvaRestart;
        public GameObject canvaPlayAgain;

    public void Start()
        {
            player = GameObject.FindObjectOfType<Movimentacao>();

            canvaRestart.SetActive(false);
        }


    public void Update()
        {
            Ativando();
        }

    public void Ativando()
        {
            if(!player.VerificaVidaPlayer())
                {
                    canvaRestart.SetActive(true);
                }
        }


    public void Desativando()
        {
            canvaRestart.SetActive(false);
        }

}
