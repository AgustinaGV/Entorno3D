using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatUI : MonoBehaviour
{

    public Text field;
    Talk talkState;

    private void Awake() {

        Hide();

    }

    public void Init(string text, Talk talkState) {

        this.talkState = talkState; //me guardo el estado talk para poder usarlo fuera del Init;
        gameObject.SetActive(true);
        field.text = text;

    }

    public void Hide() {

        gameObject.SetActive(false);

    }

    public void OnClickedA() {

        talkState.Heal();

    }

    public void OnClickedB() {

        talkState.Give();
        
    }
}
