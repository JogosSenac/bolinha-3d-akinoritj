using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class Textos : MonoBehaviour
{
    public TextMeshProUGUI textoPontos;
    public TextMeshProUGUI textoDeveres;
    private Movimentacao player;
    
    void Start()
    {
        player = GameObject.FindObjectOfType<Movimentacao>();
        AtualizarTexto();
    }

    
    void Update()
    {
        AtualizarTexto();  
    }

    void AtualizarTexto()
    {
        textoPontos.text = player.PegaPontos().ToString() + "/45";
        if(player.PegaPontos() == 0)
        {
            textoDeveres.text = ("Colete as 45 moedas existentes sem cair na lava!");
        }  

        if(player.PegaPontos() == 15)
        {
            textoDeveres.text = ("Mais 30!");
        }
        
        if(player.PegaPontos() == 30)
        {
            textoDeveres.text = ("Só faltam 15!");
        }

        if(player.PegaPontos() == 45)
        {
            textoDeveres.text = ("Agora você pode ir para a próxima fase!");
        }

        if(player.estaVivo == false)
        {
            textoDeveres.text = ("Você foi de Corinthians!!! arere o cortinas vai jogar a serie B eeeee");
        }
    }
}
