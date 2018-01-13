using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class TankTransition 
{
    public TankDecision decision;
    public TankState trueState;
    public TankState falseState;
}
