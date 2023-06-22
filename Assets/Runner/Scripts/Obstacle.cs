using System.Collections;
using System.Collections.Generic;
using HyperCasual.Core;
using UnityEngine;
using HyperCasual.Gameplay;
namespace HyperCasual.Runner
{
    /// <summary>
    /// Ends the game on collision, forcing a lose state.
    /// </summary>
    [ExecuteInEditMode]
    [RequireComponent(typeof(Collider))]
    public class Obstacle : Spawnable
    {
        [SerializeField]
        private int k_Count;
        public ObstacleCollisionEvent k_Event;
        const string k_PlayerTag = "Player";

        void OnTriggerEnter(Collider col)
        {
            if (!col.CompareTag(k_PlayerTag))
                return;

            k_Event.Count = k_Count;
            k_Event.Raise();
            gameObject.SetActive(false);
        }
    }
}