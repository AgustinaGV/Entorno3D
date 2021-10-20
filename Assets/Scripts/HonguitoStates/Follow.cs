using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : HonguitoState
{

    int distanceToStopFollow = 31;
    int limit = 4;
    float speed = 5;
    Character character;

    public override void Init() {
        character = honguito.character;
    }

    private void Update() {

        if (character == null) {
            Alert();
            return;
        }
        
        honguito.lookAtTarget.LookAt(character);
        float distanceToCharacter = Vector3.Distance(transform.position, character.transform.position);

        if(distanceToCharacter > distanceToStopFollow) {
            Alert();
        } else if (distanceToCharacter < limit){
           honguito.SetNewState(states.TALK);
        } else {
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
            
    }

    void Alert() {
        honguito.SetNewState(states.ALERT);
    }
}
