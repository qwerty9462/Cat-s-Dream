using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Cinemachine;

public class PlayerStatus : MonoBehaviour
{
    public int beanHolds;
    public int beansCollected;
    public float runSpead;
    public float viewInCave;
    public bool[] Seen = new bool [5];
    public bool[] triger = new bool [5];
    public bool[,] beanCollect = new bool [5,10];
    private Vector2 savePoint;


    void Start()
    {
        GameObject.DontDestroyOnLoad(gameObject);
        beanHolds = 0;
        runSpead = 1;
        viewInCave = 1;
        for (int i = 0; i < triger.Length; i++){
            triger[i] = false;
        }
        for(int i =0; i < 5; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                beanCollect[i,j] = false;
            }
        }
    }

    void Update()
    {
        
    }
    public void Spawn(Vector3 pos)
    {
        transform.position = pos;
        GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>().enabled = false;
        GameObject.Find("CM vcam1").GetComponent<CinemachineVirtualCamera>().enabled = true;
        //Debug.Log("move to " + transform.position);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bean")
        {
            //Debug.Log(other.name);           
            int num = int.Parse(other.name.Remove(0, 4));
            //Debug.Log(num);
            int level = GameObject.Find("BeanController").GetComponent<BeanSpawner>().getLevel();
            //Debug.Log(level);
            beanCollect[level, num] = true;            
            beanHolds++;
            beansCollected++;
            GameObject.Find("beanCount").GetComponent<Text>().text = beanHolds.ToString();
            other.gameObject.SetActive(false);
        }
        if (other.tag == "SavePoint")
        {
            savePoint = other.transform.position;
        }
        if (other.tag == "Enemy")
        {
            Spawn(savePoint);
        }
    }
    public void SetSeen(int num)
    {
        Seen[num-1] = true;
    }
    public bool[] GetSeenList()
    {
        return Seen;
    }
}
