using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    // Virtual = funciones que pueden ser extendidas, sobreescritas por otras clases
    public int score;
    public string objectName;
    public Sprite thumb;
    public int power;

    public virtual void OnInteract(Character character)
    {
        Pickup pickup = GetComponent<Pickup>();
        if (pickup != null)
        {
            pickup.OnGrab(character);
        }
    }
    public void UseIt()
    {
        Pickup pickup = GetComponent<Pickup>();
        if (pickup != null)
        {
            pickup.Drop();
        }
    }
  

}


