using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CodeMonkey.Utils;

public class UI_Shop : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;
    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);

    }
    private void Start()
    {
        CreateItemButton(items.getSprite(items.ItemName.Cat_Bed), "Bed", items.getPrice(items.ItemName.Cat_Bed), 0);
        CreateItemButton(items.getSprite(items.ItemName.Cat_Food), "Food", items.getPrice(items.ItemName.Cat_Food), 1);
        CreateItemButton(items.getSprite(items.ItemName.Cat_Key), "Key", items.getPrice(items.ItemName.Cat_Key), 2);
        CreateItemButton(items.getSprite(items.ItemName.Cat_Scratcher), "Scratcher", items.getPrice(items.ItemName.Cat_Scratcher), 3);
        CreateItemButton(items.getSprite(items.ItemName.Cat_Toy), "Toy", items.getPrice(items.ItemName.Cat_Toy), 4);
        Hide();
    }
    private void CreateItemButton(Sprite ItemImage, string ItemName, int ItemPrice, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        shopItemTransform.gameObject.SetActive(true);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHoriz = 1.5f;
        shopItemRectTransform.anchoredPosition = new Vector2(shopItemHoriz * positionIndex,0);

        shopItemTransform.Find("ItemName").GetComponent<TextMeshProUGUI>().SetText(ItemName);
        shopItemTransform.Find("ItemPrice").GetComponent<TextMeshProUGUI>().SetText(ItemPrice.ToString());
        shopItemTransform.Find("ItemImage").GetComponent<Image>().sprite = ItemImage;

        shopItemTransform.GetComponent<Button_UI>().ClickFunc = () =>
         {
             TryBuyItem(ItemName);
             //enabled = false;     
             
         };
        Debug.Log("Button created ");
    }
    private void TryBuyItem(string ItemName)
    {

        Debug.Log("You bought a " + ItemName);
    }
    public void Show()
    {
        Debug.Log("Shop shows");
        gameObject.SetActive(true);
    }
    public void Hide()
    {
        Debug.Log("Shop hides");
        gameObject.SetActive(false);
    }
}
