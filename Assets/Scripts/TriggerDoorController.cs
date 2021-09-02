using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : InteractiveObject
{

  public GameObject door;
  public Animator anim;
  

  /* CODIGO ORIGINAL QUE ABRE LA PUERTA SOLA, SIN OBJ PADRE;

    public Animator openDoor;
    void Start() {
        openDoor = GetComponent<Animator>();
    }
    public void OnTriggerEnter (Collider other) {
        openDoor.CrossFadeInFixedTime("openDoor", 0);
    }*/


  public override void OnSomethingEnter (GameObject go) {
    
    print("se abre");
    anim.Play("open");
    base.OnSomethingEnter(go);
  }

  public override void OnSomethingExit (GameObject go) {
    
    print("se cierra");
    anim.Play("close");
    base.OnSomethingExit(go);
  }

  
}
