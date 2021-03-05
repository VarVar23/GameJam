using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TubeGravity : MonoBehaviour
{
    [SerializeField] private float _gravityForceValue;
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            other.gameObject.GetComponent<Rigidbody>().AddForce(Vector3.down * _gravityForceValue, ForceMode.Force);
        }
    }
}
