using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public Character character;

    public void OnGrab(Character character)
    {
        this.character = character;
        character.inventory.Add( GetComponent<InteractiveObject>() );
    }
    public void Drop()
    {
        this.gameObject.SetActive(true);
        character.inventory.Remove(GetComponent<InteractiveObject>() );
    }

}
