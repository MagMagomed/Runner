using Codice.CM.Common.Serialization.Replication;
using HyperCasual.Core;
using HyperCasual.Gameplay;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Backpack : MonoBehaviour
{
    [SerializeField]
    private GenericGameEventListener m_onPackagePickedUpListener;
    [SerializeField]
    private GameObject pickedUpPackagePrefab;

    private int packageCount;
    public void Start()
    {
        m_onPackagePickedUpListener.Subscribe();
        m_onPackagePickedUpListener.EventHandler = PutPackageToTheBackpack;
    }
    public void ShowPackageCount()
    {
        if (m_onPackagePickedUpListener.m_Event is ItemPickedEvent packagePickedEvent)
        {
            packageCount++;
            Debug.Log(packageCount);
        }
    }
    public void PutPackageToTheBackpack()
    {
        if (m_onPackagePickedUpListener.m_Event is ItemPickedEvent packagePickedEvent)
        {
            packageCount++;
            PutPackage();
        }
    }
    public void PutPackage()
    {
        if (transform.childCount < 1)
        {
            AddPackage();
        }
        else
        {
            AddPackage(transform.GetChild(transform.childCount - 1).gameObject);
        }
    }
    public void AddPackage(GameObject lastPackage)
    {
        if (lastPackage == null)
        {
            return;
        }
        var pickedUpPackage = Instantiate(pickedUpPackagePrefab);
        pickedUpPackage.transform.position = new Vector3(
                                                            lastPackage.transform.position.x,
                                                            lastPackage.transform.position.y + (pickedUpPackage.transform.localScale.y),
                                                            lastPackage.transform.position.z
                                                        );
        pickedUpPackage.transform.SetParent(transform);
    }
    public void AddPackage()
    {
        var rendere = GetComponent<Renderer>();
        if (rendere == null)
        {
            return;
        }
        var bottomPosition = rendere.bounds.min;
        var pickedUpPackage = Instantiate(pickedUpPackagePrefab);
        pickedUpPackage.transform.position = new Vector3(
                                                            transform.position.x,
                                                            bottomPosition.y + (pickedUpPackage.transform.localScale.y),
                                                            transform.position.z
                                                        );
        pickedUpPackage.transform.SetParent(transform);
    }
}
