using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedas : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        QtdMoedas qtdMoedas = other.GetComponent<QtdMoedas>();
        
        if(qtdMoedas != null )
        {
            qtdMoedas.MoedasColetadas();
            gameObject.SetActive(false);
        }
    }

}

