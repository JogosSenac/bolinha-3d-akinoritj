using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ativador : MonoBehaviour
{
    public GameObject canvaCredit;
    public GameObject canvaMenu;

    public void Start()
    {
        canvaCredit.SetActive(false);
        canvaMenu.SetActive(true);
 
    }

    public void Ativo()
    {
        canvaCredit.SetActive(true);
        canvaMenu.SetActive(false);
    }

    public void Unable()
    {
        canvaCredit.SetActive(false);
        canvaMenu.SetActive(true);
    }
}
