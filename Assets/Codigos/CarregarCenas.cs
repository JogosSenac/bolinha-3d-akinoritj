using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenas : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");

    }
    
    public void VoltarMenu()
    {
        SceneManager.LoadScene("Menuu");
    }
    public void Replay()
    {
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1.0f;
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("Fase2");
        Time.timeScale = 1.0f;

    }
}
