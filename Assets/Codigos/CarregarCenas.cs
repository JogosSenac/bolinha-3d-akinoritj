using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarregarCenas : MonoBehaviour
{
    [SerializeField] private AudioClip play;
    private AudioSource playSource;

    public void Jogar()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    private void VoltarMenu()
    {
        playSource.PlayOneShot(play);
        SceneManager.LoadScene("Menuu");
    }
    private void Replay()
    {
    
    }
}
