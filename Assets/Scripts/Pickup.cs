using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    Character character;
    Transform originalParent;

    private void Start() {
        originalParent = transform.parent;
    }

    public void OnGrab(Character character)
    {
        this.character = character;
        character.ioActive = null;
        this.gameObject.SetActive(false);
        character.inventory.Add( GetComponent<InteractiveObject>() );

        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<Collider>().enabled = false;
        transform.SetParent(character.hand);
        transform.localPosition = Vector3.zero;
    }
    public void Drop()
    {
        this.gameObject.SetActive(true);
        character.inventory.Remove(GetComponent<InteractiveObject>() );

        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Collider>().enabled = true;
        transform.SetParent(originalParent);
    }

}
