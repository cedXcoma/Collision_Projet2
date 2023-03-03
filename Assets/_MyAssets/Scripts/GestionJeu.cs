using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{

    // Attributs
    private int _pointage;
    private int _accrochageNiveau1 = 0;
    private float _tempsNiveau1 = 0.0f;

    private void Awake()
    {
        int nbGestionJeu = FindObjectsOfType<GestionJeu>().Length;
        if (nbGestionJeu > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    // Start is called before the first frame update
    private void Start()
    {
        _pointage = 0;
        Instructions();
    }

    private static void Instructions()
    {
        Debug.Log("*** Course à obstacles ***");
        Debug.Log("Atteindre la fin du parcours le plus rapidement possible");
        Debug.Log(" Chaque obstacle qui sera touché entraînera une pénalité");
    }

    // Méthodes publiques

    public void AugmenterPointage() 
    {
        _pointage++;
        Debug.Log("Nombres d'acrochages : " + _pointage);
    }
    public int GetPointage()
    {
        return _pointage; 
    }

    public float GetTempsNiv1()
    {
        return _tempsNiveau1;
    }

    public int GetAccrochageNiv1()
    {
        return _accrochageNiveau1;
    }

    public void SetNiveau1(int accrochages, float tempsNiv1)
    {
        _accrochageNiveau1 = accrochages;
        _tempsNiveau1 = tempsNiv1;
    }
}
