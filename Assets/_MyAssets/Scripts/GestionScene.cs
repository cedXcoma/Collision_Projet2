using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionScene : MonoBehaviour
{
   public void ChangerSceneSuivante() 
    {
        int indexScene = SceneManager.GetActiveScene().buildIndex; // Récupère l'index de la scene en cours
        SceneManager.LoadScene(indexScene+1);
    }

    public void Quitter()
    {
        Application.Quit();
    }

    public void ChargerSceneDepart()
    {
        SceneManager.LoadScene(0);
    }
}
