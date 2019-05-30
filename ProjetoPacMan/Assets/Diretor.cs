using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
    public static int pontos = 0;
    public int pontosMaximo = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (pontos >= pontosMaximo)
        {
            Debug.Log("Ganhou!!");
            Time.timeScale = 0;
        }
    }

    public void AdicionarPontos()
    {
        pontos++;
    }

    public void AdicionarPontosMaximo(int numeroDePontos)
    {
        pontosMaximo = numeroDePontos;
    }
}
