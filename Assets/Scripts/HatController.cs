using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HatController : InteractiveObject
{

    public WearableObject asset_to_wear;

    public override void UseIt() { //se llama cuando clickeo el thumb del inventario;
        character.actions.WearObject(asset_to_wear); //
        print ("UseIt: soy un gorro, te abrigo. No me dejo");
    }

}
