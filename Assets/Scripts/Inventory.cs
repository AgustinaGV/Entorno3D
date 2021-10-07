using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<InteractiveObject> all; //logica del inventario;
    [HideInInspector] public int totalItems = 10;
    public InventoryUI ui; // UI del inventario;

    public void Add(InteractiveObject io)
    {
        // primero se fija si el inventario esta lleno. Si no lo esta, lo agrega a la lista de InteractiveObject y lo agrega a la UI, que servia InventoryUI;
        if(IsFull()) return;
        all.Add(io); //lo agrega en la logica;
        ui.Add(io); //lo agrega en la interfaz;
    }
    public void Remove(InteractiveObject io)
    {
        if(IsFull()) return;
        all.Remove(io);
        ui.Remove(io);
    }
    public bool IsFull()
    {
        if (all.Count >= totalItems) {
            return true;
        }
        return false;
    }
    
    public Pickup GetPickupObject()
    {
        foreach(InteractiveObject io in all)
        {
            if (io.GetComponent<Pickup>())
                return io.GetComponent<Pickup>();
        }
        return null;
    }
}
