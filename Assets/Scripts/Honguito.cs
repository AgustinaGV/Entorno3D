using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Honguito : InteractiveObject
{
   public enum states
    {
        IDLE,
        ALERT,
        FOLLOW,
    }
    public List<HonguitoState> allStates;
    public states state;

    public void SetNewState(states state)
    {
        this.state = state;
    }

}
