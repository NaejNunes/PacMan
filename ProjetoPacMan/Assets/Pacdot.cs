﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacdot : MonoBehaviour
{
    public Diretor diretor;

    // Start is called before the first frame update
    void Start()
    {
        diretor = GameObject.FindObjectOfType<Diretor>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D co)
    {
        if (co.name == "pacman")
        {
            diretor.AdicionarPontos();
            Destroy(gameObject);
        }
    }
}
