using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Slider vida;

    void Start()
    {
        vida.value = 10000f;
    }

    void Update()
    {
        if (vida.value <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void ReceberDano(int dano)
    {
        vida.value -= dano * Time.deltaTime;
    }
}
