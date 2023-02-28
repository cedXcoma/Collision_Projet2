using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionJeu : MonoBehaviour
{

    // Attributs
    private int _pointage;

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

}
