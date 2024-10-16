using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasManager : MonoBehaviour
{
  
   
    public void EmpezarPartida()
    {
        SceneManager.LoadScene(1);
    }
    public void Terminarjuego()
    {
        Application.Quit();
    }
}
