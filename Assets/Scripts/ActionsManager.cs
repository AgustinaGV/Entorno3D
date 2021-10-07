using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionsManager : MonoBehaviour
{
    public Transform hand;
    public Transform head;
    //public WearableObject wearObject = null;
    public UsableObject grabbedObject = null;
    
    string usableObjectName = "";
    //string wearableObjectName = "";

    public void GetObject(UsableObject usableObject)
    {
        if (grabbedObject != null && usableObject.name == usableObjectName)
        {
            ResetGrabbedItems();
            return;
        }
        ResetGrabbedItems();
        usableObjectName = usableObject.name;
        grabbedObject = Instantiate(usableObject, hand);
        grabbedObject.transform.localPosition = Vector3.zero;
    }
    void ResetGrabbedItems()
    {
        if (grabbedObject != null)
            Destroy(grabbedObject.gameObject);
        grabbedObject = null;
    }
    public UsableObject HasSomethingUsableInHand()
    {
        return hand.GetComponentInChildren<UsableObject>();
    }

    public void WearObject(WearableObject wObject) {
        WearableObject wO  = Instantiate(wObject, head);
        wO.transform.localPosition = Vector3.zero;
    }
   
}
