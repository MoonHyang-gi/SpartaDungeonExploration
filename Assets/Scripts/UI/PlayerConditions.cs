using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConditions : MonoBehaviour
{
    public UICondition uiCondition;

    Condition health { get { return uiCondition.health; } }

}
