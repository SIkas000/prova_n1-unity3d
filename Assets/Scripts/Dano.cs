using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dano : MonoBehaviour
{
    public int Damage;

    private void OnCollisionStay(Collision collision)
    {
        Vida vida = collision.gameObject.GetComponent<Vida>();
        if (vida != null)
        {
            vida.ReceberDano(Damage);
        }
    }
}
