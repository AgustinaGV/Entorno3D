using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{
    InteractiveObject io;
    public Text field;

    public void Init(InteractiveObject io)
    {
        this.io = io;
        field.text = io.name; //agrega nombre del gameObject;
    }
    public void Clicked()
    {
        io.UseIt(); //llama a la funcion de INteractiveObject para droppear el obj;

    }
}
