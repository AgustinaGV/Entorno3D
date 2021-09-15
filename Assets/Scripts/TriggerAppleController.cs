using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerAppleController : InteractiveObject
{
  public GameObject apple;
  public Character character;
  /*public Text inventoryText;*/

  /*public override void OnSomethingEnter (GameObject go) {
    
    //print("agarraste una manzana, iuju");
    character.collectedApples = character.collectedApples+1;
    inventoryText.text += gameObject.name.ToString() + "\n";
    Destroy(gameObject);
    base.OnSomethingEnter(go);
  }

  public override void OnSomethingExit (GameObject go) {
    
    //print("dejaste de agarrar una manzana, qué hambre");
    base.OnSomethingExit(go);
  }*/
}
