using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : InteractiveObject
{
    public InputManager inputManager;
    public float speed;
    public float rotationSpeed;
    public int collectedApples = 0;
    public int id;
    public Inventory inventory;
    public InteractiveObject ioActive;
  
    void Update()
    {
        // velocidad a la que se mueve, deltaTime para establecer un flow de movimiento comun para distintos procesadores ;
        float rotationValue = inputManager.horizontalAxis;
        if (rotationValue != 0) {
            transform.Rotate(Vector3.up * rotationValue * rotationSpeed * Time.deltaTime);
        }
        
        Vector3 moveVector = (Vector3.forward * inputManager.verticalAxis);
        if (moveVector != Vector3.zero) {
            transform.Translate(moveVector * speed * Time.deltaTime);
        }
    }

    public void OnInteract()
    {
       // Pickup pickUpObject = inventory.GetPickupObject();
        if (ioActive != null) //es "agarrable"?
            ioActive.OnInteract(this);
    }

    private void OnTriggerEnter(Collider other)
    {
        // choca con interactive object? va a OnSomethingEnter
        InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
        if (io != null) { ioActive = io; } //ioActive es el objeto con el que interactuo;
    }
    private void OnTriggerExit(Collider other)
    {
        InteractiveObject io = other.gameObject.GetComponent<InteractiveObject>();
        if (io != null) {ioActive = null; }
    }

}
