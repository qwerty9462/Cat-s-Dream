using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : MonoBehaviour
{
    public string prevScene;
    public Vector3 prevPosition;
    public Vector3 spwanPoint;
    private GameObject player;
    private bool inTriger;

    public void Start()
    {
        player = GameObject.Find("Player");
    }
    public void Transit(string dest, Vector3 pos)
    {
        SceneManager.LoadScene(dest);
        spwanPoint = pos;
        //Debug.Log("Spwan Point: " + spwanPoint);
        player.GetComponent<PlayerStatus>().Spawn(spwanPoint);
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Exit" && !inTriger)
        {
            int num = int.Parse(other.GetComponent<moveTo>().GetDest().Remove(0, 5));
            //Debug.Log("Enter level " + num);
            GameObject.Find("Player").GetComponent<PlayerStatus>().SetSeen(num);
            Transit(other.GetComponent<moveTo>().to, other.GetComponent<moveTo>().pos);
        }
        if (other.name == "ShopEnte" && !inTriger)
        {
            prevScene = SceneManager.GetActiveScene().name;
            prevPosition = transform.position;
            Transit(other.GetComponent<moveTo>().to, other.GetComponent<moveTo>().pos);
            inTriger = true;
        }
        if(other.name == "ShopExit" && !inTriger)
        {
            Transit(prevScene, prevPosition);
            inTriger = true;
        }
    }
    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.name == "ShopEnte" || other.name == "ShopExit") { inTriger = false; }      
    }
}