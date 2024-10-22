using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Movimentacao : MonoBehaviour
{

    private float moveH;
    private float moveV;
    private Rigidbody rb;
    [SerializeField] private float velocidade;
    [SerializeField] private float forcaPulo;
    [SerializeField] private bool invertH;
    [SerializeField] private bool invertV;
    [SerializeField] public bool estaVivo;
    [SerializeField] public int pontos;
    [Header ("Sons da Bolinha")]
    [SerializeField] private AudioClip pulo;
    [SerializeField] private AudioClip pegaCubo;
    [SerializeField] private AudioSource audioPlayer;


    void Start()
    {
        estaVivo = true;
        rb = GetComponent<Rigidbody>();  
        audioPlayer = GetComponent<AudioSource>();
        
    } 

    void Update()
    {
        if(estaVivo == true)
        {
            moveV = Input.GetAxis("Vertical");
            moveH = Input.GetAxis("Horizontal");
            transform.position += new Vector3(moveH * velocidade * Time.deltaTime, 0, moveV * velocidade * Time.deltaTime);

            //Pulo
            if(Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(transform.up * forcaPulo, ForceMode.Impulse);
                audioPlayer.PlayOneShot(pulo);
            }
        }  
    }
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Lava"))
        {
            estaVivo = false;
            Time.timeScale = 0;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        audioPlayer.PlayOneShot(pegaCubo);
        pontos++;
    }
    public int PegaPontos()
    {
        return pontos;
    }
}
