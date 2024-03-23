using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridMenuPopulator : MonoBehaviour
{
    public GameObject menuItemPrefab; // Префаб элемента меню
    public GridLayoutGroup gridLayoutGroup; // Ссылка на компонент GridLayoutGroup

    void Start()
    {
        // Создаем несколько элементов меню для примера
        for (int i = 0; i < 9; i++)
        {
            // Создаем экземпляр префаба элемента меню
            GameObject menuItem = Instantiate(menuItemPrefab, transform);

            // Устанавливаем текст или изображение для элемента меню
            Text menuItemText = menuItem.GetComponentInChildren<Text>();
            if (menuItemText != null)
            {
                menuItemText.text = "Item " + i.ToString();
            }

            // Можно также настроить другие компоненты элемента меню, такие как изображение, кнопки и т.д.

            // Устанавливаем GridLayoutGroup элемента меню в качестве родителя
            menuItem.transform.SetParent(gridLayoutGroup.transform);
        }

        // Обновляем Layout чтобы элементы располагались в сетке
        gridLayoutGroup.enabled = true;
    }
}
