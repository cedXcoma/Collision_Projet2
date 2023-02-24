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
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _gestionJoueur = FindObjectOfType<Player>();
        _toucher = false;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (!_toucher)
            {
                _gestionJoueur.Arret();
                _toucher = true;
            }


        }
    }
}
