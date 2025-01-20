using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class QtdMoedas : MonoBehaviour
{
    public int NmeroMoedas { get; private set; }
    public UnityEvent<QtdMoedas> OnCoinsCollected;
    public void MoedasColetadas()
    {

        NmeroMoedas++;
        OnCoinsCollected.Invoke(this);

    }

}
