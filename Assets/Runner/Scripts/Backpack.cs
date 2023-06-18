using Codice.CM.Common.Serialization.Replication;
using HyperCasual.Core;
using HyperCasual.Gameplay;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    [SerializeField]
    private GenericGameEventListener m_onPackagePickedUpListener;
    private int packageCount;
    public void Start()
    {
        m_onPackagePickedUpListener.Subscribe();
        m_onPackagePickedUpListener.EventHandler = ShowPackageCount;
    }
    public void ShowPackageCount()
    {
        if(m_onPackagePickedUpListener.m_Event is ItemPickedEvent packagePickedEvent)
        {
            packageCount++;
            Debug.Log(packageCount);
        }
    }
}
