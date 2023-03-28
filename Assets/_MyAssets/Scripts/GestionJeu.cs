using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GestionJeu : MonoBehaviour
{

    // Attributs
    private int _pointage;
    private int _accrochageNiveau1 = 0;
    private float _tempsNiveau1 = 0.0f;
    private bool _enPause = false;
    // [SerializeField] private Text _txtAccrochage = default; //Ancien Text Legacy
    [SerializeField] private TMP_Text _txtAccrochage = default;
    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private GameObject _menuPause = default;
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

        /*if(SceneManager.GetActiveScene().buildIndex ==0) 
        {
            Destroy(gameObject);
        }*/
    }

    // Start is called before the first frame update
    private void Start()
    {
        _pointage = 0;
        _txtAccrochage.text = "Accrochages : " + _pointage;
        Instructions();
        _menuPause.SetActive(false);
    }

    private void Update()
    {
        _txtTemps.text = "Temps : "+Time.time.ToString("f2");
        if(Input.GetKeyDown(KeyCode.Escape) && !_enPause) 
        {

            _menuPause.SetActive(true);
            Time.timeScale = 0;
            _enPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape)&& _enPause) 
        {
            _menuPause.SetActive(false);
            Time.timeScale = 1;
            _enPause = false;
        }
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
        _txtAccrochage.text = "Accrochages : " + _pointage;
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
