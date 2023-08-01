using HyperCasual.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(PauseShopEvent),
    menuName = "Runner/" + nameof(PauseShopEvent))]
public class PauseShopEvent : AbstractGameEvent
{
    public override void Reset()
    {
        Debug.Log($"Reset");
    }
}
