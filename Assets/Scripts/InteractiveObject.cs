using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{

    public string objectName;
    public Sprite thumb;

    // Virtual = funciones que pueden ser extendidas, sobreescritas por otras clases
   public virtual void OnSomethingEnter(GameObject go) {
       
   }

   public virtual void OnSomethingExit(GameObject go) {
       
   }

   public virtual void OnInteract(Character character) {
       // tiene el componente pickup? lo agarra;
       Pickup pickup = GetComponent<Pickup>();
       if (pickup != null) {
           pickup.OnGrab(character);
       }
   }

   public void UseIt() {
       Pickup pickup = GetComponent<Pickup>();
       if (pickup != null) {
           pickup.Drop();
       }  
   }

}



