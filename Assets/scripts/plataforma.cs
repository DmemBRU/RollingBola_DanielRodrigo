using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plataforma : MonoBehaviour
{
    [SerializeField] Vector3 direccion;
    [SerializeField] float velocidad;
    float temporizador = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( direccion* velocidad * Time.deltaTime);
        temporizador += 1 * Time.deltaTime;
        if (temporizador >= 5) 
        {
            velocidad *= -1;
            temporizador = 0;
        }
    }
}
