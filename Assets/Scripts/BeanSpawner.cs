using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeanSpawner : MonoBehaviour
{
    private GameObject player;
    public int level;
    public GameObject[] Bean;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        level = int.Parse(SceneManager.GetActiveScene().name.Remove(0, 5));
        for(int i = 0; i<10; i++)
        {
            if (player.GetComponent<PlayerStatus>().beanCollect[level,i])
            {
                Bean[i].SetActive(false);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int getLevel()
    {
        return level;
    }
}
