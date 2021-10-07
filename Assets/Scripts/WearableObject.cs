using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WearableObject : MonoBehaviour
{
    public types type;
    public enum types {
        HEAD,
        FOOT,
        BODY,
        HAND
    }

    public void Wear() {
        print("wear");
    }
}
