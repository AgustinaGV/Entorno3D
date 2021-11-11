using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HonguitoState : MonoBehaviour
{
    public Honguito honguito;
    public states state;
    public enum states
    {
        IDLE,
        ALERT,
        FOLLOW,
        TALK
    }

    private void Start() {

        honguito = GetComponent<Honguito>();
    }

    public virtual void Init() {} //que hace cuando arranca el estado? overrideo y le mando;

    public virtual void OnCharacterEnterViewZone(Character character) {

        print("entro y soy HonguitoState : " + character);

    }

    public virtual void OnCharacterExitViewZone(Character character) {

        print("salio y soy HonguitoState : " + character);
        
    }

}
