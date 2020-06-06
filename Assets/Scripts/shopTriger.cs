using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopTriger : MonoBehaviour
{
    [SerializeField] private UI_Shop uiShop;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        uiShop.Show();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        uiShop.Hide();
    }
}
