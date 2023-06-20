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
    private GenericGameEventListener m_onObstacleCollisionListener;
    [SerializeField]
    private GameObject pickedUpPackagePrefab;

    private int packageCount;
    public void Start()
    {
        m_onPackagePickedUpListener.Subscribe();
        m_onPackagePickedUpListener.EventHandler = PutPackageToTheBackpack;

        m_onObstacleCollisionListener.Subscribe();
        m_onObstacleCollisionListener.EventHandler = OnObstacleCollisionHandler;
    }
    public void OnObstacleCollisionHandler()
    {
        if (m_onPackagePickedUpListener.m_Event is ItemPickedEvent packagePickedEvent)
        {
            packageCount--;
            DeletePackage();
        }
    }

    private void DeletePackage()
    {
        GameObject child = null;
        for (int i = transform.childCount - 1; i > -1; i--)
        {
            if (transform.GetChild(i).gameObject.CompareTag("Package"))
            {
                child = transform.GetChild(i).gameObject;
                Destroy(child);
                break;
            }
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
        GameObject child = null;
        for (int i = transform.childCount - 1; i > -1; i--)
        {
            if (transform.GetChild(i).gameObject.CompareTag("Package"))
            {
                child = transform.GetChild(i).gameObject;
                break;
            }
        }
        AddPackage(child);
    }
    public void AddPackage(GameObject lastPackage)
    {
        if (lastPackage == null)
        {
            AddPackage();
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
