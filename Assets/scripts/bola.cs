using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;


public class bola : MonoBehaviour
{

     Vector3 posicionOriginal ;
    Rigidbody rb;
    [SerializeField] int velocidad;
    [SerializeField]Vector3 direccionSalto;
    [SerializeField] int fuerzasalto;
    Vector3 direccion;
    [SerializeField] int fuerza;
    [SerializeField] int vida;
    [SerializeField] TMP_Text textoVida;
    [SerializeField]int puntuacion;
    [SerializeField]TMP_Text textoPuntuacion;
    [SerializeField] AudioClip sonidoColeccionable;
    [SerializeField] AudioClip sonidoMuerte;
    [SerializeField] AudioManager manager;
    private Camera cam;

    [SerializeField] LayerMask queEsSuelo;
    [SerializeField] float distanciaDeteccionSuelo;
    // Start is called before the first frame update
    void Start()
    {
        posicionOriginal = transform.position;
       rb =GetComponent<Rigidbody>();
        cam = Camera.main;
        textoPuntuacion.SetText("Puntos: " + puntuacion);
        textoVida.SetText("Vida: " + vida);

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
            if (detectarSuelo() == true)
            {
                GetComponent<Rigidbody>().AddForce(direccionSalto * fuerzasalto, ForceMode.Impulse);
            }
           
        }
        //Existe el FixedUpdate que es un ciclo de fisicas el cual es constante se reproduce cada 0.02 segundos SIEMPRE
       
        

    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "coleccionable")
        {
            puntuacion++;
            Destroy(other.gameObject);
            //manager.reproducirSonido(sonidoColeccionable);
            
            
            textoPuntuacion.SetText("Score: " + puntuacion);
        }
        if(other.gameObject.CompareTag("trampa"))
        {
            Destroy(other.gameObject);
            vida -- ;
            textoVida.SetText("Vida: " + vida);
        }
        if (vida <= 0)
        {
            //manager.reproducirSonido(sonidoMuerte);
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
        }

        if (other.gameObject.CompareTag("zonaMuerte"))
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(2);
        }
    }

    bool detectarSuelo()
    {
        bool resultado = Physics.Raycast(transform.position, new Vector3(0, -1, 0), distanciaDeteccionSuelo, queEsSuelo);
        return resultado;
    }
}
