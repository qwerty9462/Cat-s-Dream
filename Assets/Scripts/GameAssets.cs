using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;
    public static GameAssets i
    {
        get
        {
            if (_i == null) _i = (Instantiate(Resources.Load<GameAssets>("GameAssets")));
            return _i;
        }
    }
    public Sprite Cat_Bed;
    public Sprite Cat_Food;
    public Sprite Cat_Key;
    public Sprite Cat_Scratcher;
    public Sprite Cat_Toy;
}
