using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : HonguitoState
{

    public ChatUI chatUI;
    public int limit = 5;
    public states stateActivatedByDistance = states.FOLLOW; //desde Unity le digo a qué estado se va, varía segun el personaje;

    public SpeachData[] speach;
    int id;

    [System.Serializable]
    public class SpeachData {
        public int id;
        public int gotoId;
        public string text;
        public MultipleChoiceData[] multiplechoice;
    }

    [System.Serializable]
    public class MultipleChoiceData {
        public string text;
        public int gotoId;
    }

    public override void Init() {
    
        id = 0;
        //chatUI.Init("Hola soy El Honguito. Tengo poderes mágicos", this); //el this le pasa la clase entera TALK, para que la tenga de referencia y poder llamar a sus estados;
        chatUI.Init(speach, this);
    }

    private void Update() {

        float distanceToCharacter = Vector3.Distance(transform.position, honguito.character.transform.position);
        if(distanceToCharacter > limit) {
            honguito.SetNewState(stateActivatedByDistance);
            chatUI.Hide();
        }  
    }

    public override void OnCharacterExitViewZone(Character character) {
        
        print("sali del alert");
        honguito.SetNewState(states.IDLE);
        chatUI.Hide();
    }

}
