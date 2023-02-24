using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Attributs
    [SerializeField]private float _vitesse = 10;
    private bool jouer;

    // M�thodes priv�es
    private void Start()
    {
        jouer = true;
        //Position de d�part du joueur
        this.transform.position = new Vector3(-28f,0.51f,-31f);
    }

    private void Update()
    {
        if (jouer)
        {
            MovementsJoueur();
        }
        
    }

    private void MovementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");
        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        transform.Translate(direction * Time.deltaTime * _vitesse);
    }

    public void Arret() 
    {   
        jouer = false;
        if(!jouer) 
        {
            Debug.Log("Vous avez termin�");
        }
    }
}
