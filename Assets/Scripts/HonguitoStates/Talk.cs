using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Talk : HonguitoState
{

    public ChatUI chatUI;
    int limit = 5;
    public string[] speach;
    int id;

    public override void Init() {
        
        id = 0;
        //chatUI.Init("Hola soy El Honguito. Tengo poderes mágicos", this); //el this le pasa la clase entera TALK, para que la tenga de referencia y poder llamar a sus estados;
        TalkNext();
    }

    private void Update() {

        float distanceToCharacter = Vector3.Distance(transform.position, honguito.character.transform.position);
        if(distanceToCharacter > limit) {
            honguito.SetNewState(states.FOLLOW);
            chatUI.Hide();
        }  
    }

    public override void OnCharacterExitViewZone(Character character) {
        
        print("sali del alert");
        honguito.SetNewState(states.IDLE);
        chatUI.Hide();
    }

    void TalkNext() {
        if (id > speach.Length - 1) {
            chatUI.Hide();
            id = 0;
        } else {
            string say = speach[id];
            chatUI.Init(say, this);
        }
    }

    public void Idle() {

        print("Soy un hongo bueno, estoy tranca");
        
    }
    public void Heal() {

        print("Soy un hongo bueno, voy a curarte");
        id++;
        TalkNext();
        
    }

    public void Give() {

        print("Soy un hongo bueno, voy a regalarte algo");
        id++;
        TalkNext();
        
    }
}
