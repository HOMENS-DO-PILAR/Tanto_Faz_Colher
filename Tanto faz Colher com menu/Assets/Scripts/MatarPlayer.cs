﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatarPlayer : MonoBehaviour
{
    public GerenciadorDeFase GerenciadorDeFase;
    // Start is called before the first frame update
    void Start()
    {
        GerenciadorDeFase = FindObjectOfType<GerenciadorDeFase>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            GerenciadorDeFase.RespawnPlayer();
        }
    }
}
