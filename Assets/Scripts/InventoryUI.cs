using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public InventoryButton button;
    public Transform container;

    public void Add(InteractiveObject io)
    {
        InventoryButton newButton = Instantiate(button, container); //agrega boton a la interfaz. El primer elemento es QUE, el segundo DONDE;
        newButton.Init(io);
    }
    public void Remove(InteractiveObject io)
    {
        print("Remove " + io.name);

        InventoryButton mybutton = null;
        InventoryButton[] allInventoryButtons = container.GetComponentsInChildren<InventoryButton>();
        foreach (InventoryButton button in allInventoryButtons)
            if (button.io == io) //es igual al que acabo de clickear? entonces es mybutton y se cual borrar;
                mybutton = button;

        if (mybutton != null) {
            Destroy(mybutton.gameObject);
        }

        //Destroy(gameObject);
    }
}
