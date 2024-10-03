using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bola : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] int velocidad;
    [SerializeField]Vector3 direccionSalto;
    [SerializeField] int fuerzasalto;
    Vector3 direccion;
    [SerializeField] int fuerza;
    // Start is called before the first frame update
    void Start()
    {
       rb =GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        direccion.z = h;
        direccion.x = v;
        rb.AddForce(direccion * fuerza, ForceMode.Force);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(direccionSalto * fuerzasalto, ForceMode.Impulse);
        }
    }
}
