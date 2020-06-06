using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class items
{
    public enum ItemName
    {
        Cat_Bed,
        Cat_Food,
        Cat_Key,
        Cat_Scratcher,
        Cat_Toy
    }
    public static int getPrice(ItemName itemName)
    {
        switch (itemName)
        {
            default:
            case ItemName.Cat_Bed: return 10;
            case ItemName.Cat_Food: return 20;
            case ItemName.Cat_Key: return 30;
            case ItemName.Cat_Scratcher: return 40;
            case ItemName.Cat_Toy: return 50;
        }
    }
    public static Sprite getSprite(ItemName itemName)
    {
        switch (itemName)
        {
            default:
            case ItemName.Cat_Bed: return GameAssets.i.Cat_Bed;
            case ItemName.Cat_Food: return GameAssets.i.Cat_Food;
            case ItemName.Cat_Key: return GameAssets.i.Cat_Key;
            case ItemName.Cat_Scratcher: return GameAssets.i.Cat_Scratcher;
            case ItemName.Cat_Toy: return GameAssets.i.Cat_Toy;
        }
    }
}
