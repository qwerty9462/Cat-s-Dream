using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelMenu : MonoBehaviour
{
    // Start is called before the first frame update
    private bool[] Seen;
    private string level;
    private void Start()
    {
        Seen = GameObject.Find("Player").GetComponent<PlayerStatus>().GetSeenList();
        for (int i=0; i< Seen.Length; i++)
        {
            if (!Seen[i])
            {
                int j = i + 1;
                level = "Level_"+ j + "_Button".ToString();
                Debug.Log(level);
                GameObject.Find(level.ToString()).GetComponent<Button>().enabled = false;
            }
        }
    }
    public void TutorialLevel()
    {
        SceneManager.LoadScene("Tutorial");
    }
    public void Level_1()
    {
        SceneManager.LoadScene("Level1");
    }
    public void Level_2()
    {
        SceneManager.LoadScene("Level2");
    }

    //public void Level_2()
    //public void Level_3()
    public void Level_4()
    {
        SceneManager.LoadScene("Level4");
    }

    public void Level_5()
    {
        SceneManager.LoadScene("Level5");
    }
    
    public void BackMainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
