using HyperCasual.Core;
using HyperCasual.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The event is triggered when the player face an obstacle
/// </summary>
[CreateAssetMenu(fileName = nameof(ObstacleCollisionEvent),
    menuName = "Runner/" + nameof(ObstacleCollisionEvent))]
public class ObstacleCollisionEvent : AbstractGameEvent
{
    [HideInInspector]
    public int Count = -1;
    public override void Reset()
    {
        Count = -1;
    }
}
