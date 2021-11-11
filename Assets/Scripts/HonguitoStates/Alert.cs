using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : HonguitoState
{

    public int distanceToFollow = 30;
    public states stateActivatedByDistance;

    private void Update() {

        if (honguito != null && honguito.character != null) {
            honguito.lookAtTarget.LookAt(honguito.character);
        }  

        float distanceToCharacter = Vector3.Distance(transform.position, honguito.character.transform.position);
        if (distanceToCharacter < distanceToFollow) {
            honguito.SetNewState(stateActivatedByDistance);
        }        
    }

    public override void OnCharacterExitViewZone(Character character) {
        
        print("sali del alert");
        honguito.SetNewState(states.IDLE);

    }
}
