using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cambioCamara : MonoBehaviour
{
    [SerializeField] private GameObject virtualCamera;
    [SerializeField] private GameObject cenital;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {

            virtualCamera.SetActive(false);
            cenital.SetActive(true);
            
        }
    }
}
