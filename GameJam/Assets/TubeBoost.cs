using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeBoost : MonoBehaviour
{
    [SerializeField] private float _boostForceValue;
    
    private void OnTriggerEnter(Collider other)
    {        
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(transform.right * _boostForceValue, ForceMode.Impulse);
        }
    }
}
