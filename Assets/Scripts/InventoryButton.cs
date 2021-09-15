using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{
    public InteractiveObject io;
    public Text field;
    public Image thumb;

    public void Init(InteractiveObject io)
    {
        this.io = io;
        field.text = io.objectName; //agrega nombre del gameObject;
        thumb.sprite = io.thumb;
    }
    public void Clicked()
    {
        io.UseIt(); //llama a la funcion de InteractiveObject para droppear el obj;

    }
}
