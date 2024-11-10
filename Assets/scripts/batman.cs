using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batman : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0.5f;


        }


    }
}
