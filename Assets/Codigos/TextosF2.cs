using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextosF2 : MonoBehaviour
{
    public TextMeshProUGUI textPontosF2;
    public TextMeshProUGUI textDeveresF2;
    private Movimentacao player;

    void Start()
    {
        player = GameObject.FindObjectOfType<Movimentacao>();
        AttTexto();
    }

    void Update()
    {
        AttTexto();
    }

    void AttTexto()
        {
        textPontosF2.text = player.PegaPontos().ToString() + "/10";
        if(player.PegaPontos() == 0)
        {
            textDeveresF2.text = ("Colete as 10 moedas existentes sem cair na Neve!");
        }  

        if(player.PegaPontos() == 3)
        {
            textDeveresF2.text = ("Mais 7!");
        }
        
        if(player.PegaPontos() == 6)
        {
            textDeveresF2.text = ("Só faltam 4!");
        }

        if(player.PegaPontos() == 10)
        {
            textDeveresF2.text = ("Agora você pode finalizar o jogo!");
        }

        if(player.VerificaVidaPlayer() == false)
        {
            textDeveresF2.text = ("Você foi de Vasco!!! arere o vasco vai jogar a serie B eeeee");
        }
    }
}
