using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movi : MonoBehaviour
{
    public float jumpHeight;
    public float speed;
    bool pulo;
    public float Trampolimforce;
    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

    }

    void Update()
    {
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * zInput * speed * Time.deltaTime);
        transform.Translate(Vector3.right * xInput * speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space) && !pulo)
        {
            rb.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
            pulo = true;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            pulo = false;
        }
        if (collision.gameObject.tag == "Trampulim")
        {
            rb.AddForce(Vector3.up * jumpHeight * Trampolimforce, ForceMode.Impulse);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Boost")
        {
            speed += 3;
            Destroy(other.gameObject);
        }
    }

}