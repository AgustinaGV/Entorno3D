using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatUI : MonoBehaviour
{

    public Text field;
    Talk talkState;
    public GameObject simpleText;
    public GameObject multipleChoice;
    Talk.SpeachData[] speachData;
    int id;

    public enum types {
        SIMPLE,
        MULTIPLE_CHOICE
    }

    private void Awake() {

        Hide();

    }

    public void Init(Talk.SpeachData[] speachData, Talk talkState) {

        this.speachData = speachData; //guardo localmente la lista;
        id = 0;
        this.talkState = talkState; //me guardo el estado talk para poder usarlo fuera del Init;
        gameObject.SetActive(true);
        field.text = speachData[id].text;

    }

    public void Init(string[] text, Talk talkState) {

        this.talkState = talkState; //me guardo el estado talk para poder usarlo fuera del Init;
        gameObject.SetActive(true);
        //field.text = text;
    }

    void SetNewLine() {
        field.text = speachData[id].text;
    }

    public void OnNext() {
        id ++;
        if (id>=speachData.Length) {
            Hide();
        }
        SetNewLine();
    }

    public void Hide() {
        gameObject.SetActive(false);
    }

    public void OnClickedA() {

        talkState.Heal();

    }

    public void OnClickedB() {

        gameObject.SetActive(false);
        
    }
}
