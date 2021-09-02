using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveObject : MonoBehaviour
{
    // Virtual = funciones que pueden ser extendidas, sobreescritas por otras clases
   public virtual void OnSomethingEnter(GameObject go) {
       
   }

   public virtual void OnSomethingExit(GameObject go) {
       
   }

  

}


