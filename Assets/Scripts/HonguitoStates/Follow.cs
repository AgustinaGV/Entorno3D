using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : HonguitoState
{

    int distanceToStopFollow = 31;
    int limit = 4;
    float speed = 8;

    private void Update() {

        if (honguito.character == null) {
            honguito.SetNewState(states.ALERT);
            return;
        }
        
        honguito.lookAtTarget.LookAt(honguito.character);
        float distanceToCharacter = Vector3.Distance(transform.position, honguito.character.transform.position);

        if(distanceToCharacter > distanceToStopFollow) {
            honguito.SetNewState(states.ALERT);
        } else if (distanceToCharacter < limit){
           honguito.SetNewState(states.TALK);
        } else {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
            
    }
}
