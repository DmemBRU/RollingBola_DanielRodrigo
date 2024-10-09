using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rodillo : MonoBehaviour
{
    
    [SerializeField] Vector3 rotacion;
    [SerializeField] int fuerza;

    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddTorque(rotacion * fuerza, ForceMode.VelocityChange);
       
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(rotacion * velocidad * Time.deltaTime);

    }
}
