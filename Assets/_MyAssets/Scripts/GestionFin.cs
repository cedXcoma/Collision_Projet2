using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GestionFin : MonoBehaviour
{
    private Player _gestionJoueur;
    private GestionJeu _gestionJeu;
    

    private void Start()
    {
        _gestionJoueur = FindObjectOfType<Player>();
        _gestionJeu = FindObjectOfType<GestionJeu>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            int indexScene = SceneManager.GetActiveScene().buildIndex;

            if(indexScene == 1)
            {                  
                int erreurs = _gestionJeu.GetPointage();
                float tempsTotalniv1 = _gestionJeu.GetTempsNiv1()+_gestionJeu.GetAccrochageNiv1();
                float _tempsNiveau2 = Time.time - _gestionJeu.GetTempsNiv1();
                int _acccrochagesNiveau2 = _gestionJeu.GetPointage() - _gestionJeu.GetAccrochageNiv1();
                float tempsTotalNiv2 = _tempsNiveau2 + _acccrochagesNiveau2;

                Debug.Log("Le temps pour le niveau 1 est de : "+ _gestionJeu.GetTempsNiv1().ToString("f2")+" secondes");
                Debug.Log("Obstacles accroché au niveau 1 : "+_gestionJeu.GetAccrochageNiv1());
                Debug.Log("Temps total pour niveau 1 : "+ tempsTotalniv1.ToString("f2"));

                Debug.Log("Le temps pour le niveau 2 est de : "+ _tempsNiveau2.ToString("f2")+ "secondes");
                Debug.Log("Obstacles accroché au niveau 2 : "+_acccrochagesNiveau2);
                Debug.Log("Temps total pour niveau 2 : "+ tempsTotalNiv2.ToString("f2"));

                Debug.Log("Temps total pour les deux niveaux est de : "+(tempsTotalniv1 + tempsTotalNiv2).ToString("f2"));

                _gestionJoueur.Arret();           
            } 
            else
            {
                //Charger la scene suivante
                _gestionJeu.SetNiveau1(_gestionJeu.GetPointage(), Time.time);
                SceneManager.LoadScene(indexScene + 1);                                  
            }
            

            

        }
    }
}
