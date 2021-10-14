using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : HonguitoState
{
    public override void OnCharacterEnterViewZone(Character character) {
        print("estoy en idle");
        honguito.SetNewState(states.ALERT);

    }

}
