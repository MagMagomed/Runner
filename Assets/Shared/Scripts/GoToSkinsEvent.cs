using HyperCasual.Core;
using NUnit.Framework.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = nameof(GoToSkinsEvent),
    menuName = "Runner/" + nameof(GoToSkinsEvent))]
public class GoToSkinsEvent : AbstractGameEvent
{
    public override void Reset()
    {
        Debug.Log($"{nameof(GoToSkinsEvent)} Reset");
    }

    
}
