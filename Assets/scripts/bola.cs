using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class bola : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] int velocidad;
    [SerializeField]Vector3 direccionSalto;
    [SerializeField] int fuerzasalto;
    Vector3 direccion;
    [SerializeField] int fuerza;
    [SerializeField] int vida;
    private int puntuacion;
    [SerializeField]TMP_Text textoPuntuacion;
    // Start is called before the first frame update
    void Start()
    {
       rb =GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal") * -1;
        float v = Input.GetAxis("Vertical") ;


        direccion.z = h;
        direccion.x = v;
        rb.AddForce(direccion.normalized * fuerza, ForceMode.Force);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(direccionSalto * fuerzasalto, ForceMode.Impulse);
        }
        //Existe el FixedUpdate que es un ciclo de fisicas el cual es constante se reproduce cada 0.02 segundos SIEMPRE
        
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "coleccionable")
        {
            Destroy(other.gameObject);
            puntuacion++;
            textoPuntuacion.SetText("Score: " + puntuacion);
        }
        if(other.gameObject.CompareTag("trampa"))
        {
            Destroy(other.gameObject);
            vida -= 10;
        }
        if (vida <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
