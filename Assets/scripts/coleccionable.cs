using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coleccionable : MonoBehaviour
{
    [SerializeField] Vector3 rotacion;
    [SerializeField] Vector3 posicion;
    [SerializeField] int velocidadROT;
    [SerializeField] int velocidad;
    float temporizador;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotacion * velocidadROT * Time.deltaTime);
        transform.Translate(posicion* velocidad * Time.deltaTime,Space.World);
        temporizador += 1 * Time.deltaTime;
        if (temporizador >= 1) 
        {
            velocidad *= -1;
            temporizador = 0;
        }

    }
}
