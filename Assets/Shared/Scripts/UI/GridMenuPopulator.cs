using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridMenuPopulator : MonoBehaviour
{
    public GameObject menuItemPrefab; // ������ �������� ����
    public GridLayoutGroup gridLayoutGroup; // ������ �� ��������� GridLayoutGroup

    void Start()
    {
        // ������� ��������� ��������� ���� ��� �������
        for (int i = 0; i < 9; i++)
        {
            // ������� ��������� ������� �������� ����
            GameObject menuItem = Instantiate(menuItemPrefab, transform);

            // ������������� ����� ��� ����������� ��� �������� ����
            Text menuItemText = menuItem.GetComponentInChildren<Text>();
            if (menuItemText != null)
            {
                menuItemText.text = "Item " + i.ToString();
            }

            // ����� ����� ��������� ������ ���������� �������� ����, ����� ��� �����������, ������ � �.�.

            // ������������� GridLayoutGroup �������� ���� � �������� ��������
            menuItem.transform.SetParent(gridLayoutGroup.transform);
        }

        // ��������� Layout ����� �������� ������������� � �����
        gridLayoutGroup.enabled = true;
    }
}
