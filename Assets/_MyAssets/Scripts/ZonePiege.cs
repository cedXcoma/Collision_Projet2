using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZonePiege : MonoBehaviour
{

    private bool _estActive = false;
    [SerializeField]private GameObject _piege = default;
    [SerializeField]private float _force = 500;
    private Rigidbody _rb;
    private void Start()
    {
        _rb = _piege.GetComponent<Rigidbody>();
        _rb.useGravity = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_estActive) 
        { 
            _rb.useGravity = true;
            //Vector3 direction = new Vector3(0f,-1f, 0f);
            _rb.AddForce(Vector3.down * _force);
        Debug.Log("Activer le piège !!!");
            _estActive = true;
        }
        
    }
}
