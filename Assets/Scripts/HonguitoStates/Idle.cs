using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : HonguitoState
{

    public states stateActivatedByDistance = states.ALERT;

    
    public override void OnCharacterEnterViewZone(Character character) {
        print("estoy en idle");
        if(honguito.isColibri) {
            print("SOY UN COLIBRI IDLE");
            honguito.SetNewState(stateActivatedByDistance);
        } else {
            honguito.SetNewState(stateActivatedByDistance);
        }
        

    }

}
