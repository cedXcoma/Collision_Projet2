using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCapsule : MonoBehaviour
{
    private Player _gestionJoueur;
    private GestionJeu _gestionJeu;
    private bool _toucher;

    private void Start()
    {
        _gestionJoueur = FindObjectOfType<Player>();
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _toucher = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_toucher)
            {
                int erreurs = _gestionJeu.GetPointage();
                _gestionJoueur.Arret();
                _toucher = true;
                Debug.Log("Le temps total est de : " + Time.time + "seconde");
                Debug.Log("Vous avez accroché " + erreurs + "  obstacles");
                float total = Time.time + erreurs;
                Debug.Log("Temps final : " + total);
                
            }


        }
    }
}
