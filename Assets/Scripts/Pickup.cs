using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Character character;

    public void OnGrab(Character character)
    {
        this.character = character;
        character.ioActive = null;
        this.gameObject.SetActive(false);
        character.inventory.Add( GetComponent<InteractiveObject>() );
    }
    public void Drop()
    {
        print("Dejando la manzana");
        this.gameObject.SetActive(true);
        character.inventory.Remove(GetComponent<InteractiveObject>() );
    }

}
