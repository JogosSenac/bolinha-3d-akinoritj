using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AnimadoLava : MonoBehaviour
{
    [SerializeField] private float speedY;
    [SerializeField] private float speedX;
    private MeshRenderer rend;
    void Start()
    {
        rend = GetComponent<MeshRenderer>();
    }
    void Update()
    {
        rend.material.mainTextureOffset = new Vector2(speedX * Time.timeSinceLevelLoad, speedY * Time.timeSinceLevelLoad);   
    }
}
