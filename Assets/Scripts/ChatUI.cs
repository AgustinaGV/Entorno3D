using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChatUI : MonoBehaviour
{

    public Text simpleField;
    public Text multiplechoiceField;

    public MultipleChoiceBtnUI multipleChoiceBtn; //en caso de un lenght > 0, se trata de un dialogo multiple choice, entonces la interfaz es otra. Que btn (prefab) tengo que instanciar?;
    public Transform mcContainer; // y donde?;

    Talk talkState;
    public GameObject simpleText;
    public GameObject multipleChoice;

    Talk.SpeachData[] speachData;
    Talk.SpeachData speachDataActive;
    int id;

    public enum types {
        SIMPLE,
        MULTIPLE_CHOICE
    }

    private void Awake() {
        Hide();
    }

    public void Init(Talk.SpeachData[] speachData, Talk talkState) {

        this.talkState = talkState; //me guardo el estado talk para poder usarlo fuera del Init;
        this.speachData = speachData; //guardo localmente la lista;
        id = 0;
        gameObject.SetActive(true);
        /*simpleField.text = speachData[id].text; GUATAFAK*/
        SetNewLine();

    }

    void SetNewLine() {
        
        speachDataActive = speachData[id];
        int length = speachDataActive.multiplechoice.Length;
        
        if(length == 0) {
            simpleField.text = speachDataActive.text;
            simpleText.SetActive(true);
            multipleChoice.SetActive(false);
        
        } else {
            MultipleChoiceBtnUI[] all = mcContainer.GetComponentsInChildren<MultipleChoiceBtnUI>();
            int i = all.Length;
            while (i>0) {
                Destroy(all[i-1].gameObject);
                i--; /*todo lo anterior desde que arranca el else es para vaciar el container*/
            }

            foreach(Talk.MultipleChoiceData mcData in speachDataActive.multiplechoice) //itero sobre esta lista; 
            {
                MultipleChoiceBtnUI button = Instantiate(multipleChoiceBtn, mcContainer);
                button.Init(this, mcData); //cada "vuelta" que doy, itero sobre la data. Se la paso directamente al boton;
            }
            multiplechoiceField.text = speachDataActive.text;
            simpleText.SetActive(false);
            multipleChoice.SetActive(true);            
        }
    }

    public void OnNext() {
        id = speachDataActive.gotoId;
        if (id == 0) {
            Hide();
        }
        SetNewLine();
    }

    public void Goto (int _id) {
        id = _id;
        SetNewLine();
    }

    public void Hide() {
        gameObject.SetActive(false);
    }

}
