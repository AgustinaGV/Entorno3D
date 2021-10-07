using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeZone : MonoBehaviour
{
    Honguito honguito;
    private void Start()
    {
        honguito = GetComponentInParent<Honguito>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Character>())
            honguito.GetComponent<LookAtTarget>().OnTarget(other.transform);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Character>())
            honguito.GetComponent<LookAtTarget>().OnTarget(null);
    }
}
