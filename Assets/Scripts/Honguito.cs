using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Honguito : InteractiveObject
{

    public List<HonguitoState> allStates;
    HonguitoState currentState;
    public LookAtTarget lookAtTarget;

    private void Start () {

        SetNewState(HonguitoState.states.IDLE);
    }


    public void SetNewState(HonguitoState.states stateType) //cuando arranco poner idle, el resto de los estados apagarlos;
    {
        foreach (HonguitoState honguitoState in allStates) {
            if (honguitoState.state == stateType) {
                this.currentState = honguitoState;
                honguitoState.enabled = true;
                currentState.Init();
            } else {
                honguitoState.enabled = false;
            }
        }   
    }

    public void OnCharacterEnterViewZone(Character character)
    {
        this.character = character;
        if (character == null) { // si es null, llamo a la funcion en la que sale el target;
            currentState.OnCharacterExitViewZone(character);
        } else {
            currentState.OnCharacterEnterViewZone(character); //que el estado sepa que algo entro a la vista del honguito;
        }
    }

}
