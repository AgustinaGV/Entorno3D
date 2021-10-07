using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{

    public string objectName;
    public Sprite thumb;
    //public int power;
    public Character character;

    // Virtual = funciones que pueden ser extendidas, sobreescritas por otras clases
   public virtual void OnSomethingEnter(GameObject go) {
   }

   public virtual void OnSomethingExit(GameObject go) {  
   }

   public virtual void OnInteract(Character character) {
       // tiene el componente pickup? lo agarra;
       this.character = character;
       Pickup pickup = GetComponent<Pickup>();
       if (pickup != null) {
           pickup.OnGrab(character);
       }
   }

   public virtual void UseIt() { //cuando clickeo el boton de UI;
       Pickup pickup = GetComponent<Pickup>();
       if (pickup != null) {
           pickup.Drop();
       }  
   }

}



