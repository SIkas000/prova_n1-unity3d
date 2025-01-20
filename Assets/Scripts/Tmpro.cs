using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tmpro : MonoBehaviour
{
    public TMP_Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    public void UpdateText(QtdMoedas qtdMoedas)
    {
        text.text =  qtdMoedas.NmeroMoedas.ToString();
    }
}
