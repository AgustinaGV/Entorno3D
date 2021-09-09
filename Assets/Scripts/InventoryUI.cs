using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public InventoryButton button;
    public Transform container;

    public void Add(InteractiveObject io)
    {
        InventoryButton newButton = Instantiate(button, container); //agrega boton a la interfaz;
        newButton.Init(io);
    }
    public void Remove(InteractiveObject io)
    {
        print("Remove " + io.name);
        //Destroy(gameObject);
    }
}
