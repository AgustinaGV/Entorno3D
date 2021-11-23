using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultipleChoiceBtnUI : MonoBehaviour
{
    public Text field;
    int gotoID;
    ChatUI chatUI;

    public void Init (ChatUI chatUI, Talk.MultipleChoiceData data) {

        this.chatUI = chatUI;
        field.text = data.text;
        gotoID = data.gotoId;
        
    }

    public void Clicked() {
        chatUI.Goto(gotoID);

    }
}
