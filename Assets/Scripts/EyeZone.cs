using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EyeZone : MonoBehaviour
{
    Honguito honguito;

    private void Update() {

    }
    
    private void Start()
    {
        honguito = GetComponentInParent<Honguito>();
    }
    private void OnTriggerEnter(Collider other)
    {
        Character character = other.gameObject.GetComponent<Character>();
        if (character != null)
            //honguito.OnCharacterEnterViewZone(other.transform);
            honguito.OnCharacterEnterViewZone(character);
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Character>())
            honguito.OnCharacterEnterViewZone(null);
    }
}
