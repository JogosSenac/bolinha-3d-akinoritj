using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimentação : MonoBehaviour
{
    private float moveH;
    private float moveV;
    private Rigidbody rb;
    [SerializeField] private float velocidade;
    [SerializeField] private float forcaPulo;
    [SerializeField] private bool invertH;
    [SerializeField] private bool invertV;
    [SerializeField] private bool estaVivo;
    [SerializeField] private bool isJumping;

    void Start()
    {
        estaVivo = true;
        rb = GetComponent<Rigidbody>();   
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
    }
}
