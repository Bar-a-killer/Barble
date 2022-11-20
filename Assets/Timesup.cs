using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Timesup : MonoBehaviour
{
    float timer_f = 0f;
    int timer_i = 0;
    // Start is called before the first frame update
    [SerializeField] public GameObject[] BagPanel;
    [SerializeField] public Text resttime;
    int i;
    void Start()
    {
        foreach(GameObject i in BagPanel)
            i.SetActive(false);
    }

    
  

    // Update is called once per frame
    void Update()
    {
        timer_f += Time.deltaTime;
        timer_i = (int)timer_f;
        if (timer_i >= 180)
        {
            for(i = 0; i < 3; i++)
                BagPanel[i].SetActive(true);
            Time.timeScale = 0f;
            
        }
        UpdateScore();
    }
    public void Replay()
    {
        Time.timeScale = 1f;
        foreach (GameObject i in BagPanel)
            i.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }

    public void Toreplay()
    {
        foreach( GameObject i in BagPanel)
        {
            i.SetActive(!i.activeSelf);
        }
        for(i = 0; i < 3; i++)
        {
            BagPanel[i].SetActive(false);
        }
        Usekey usekey = new Usekey();
        usekey.Change_key('1');
        Time.timeScale = 0f;
        timer_i = 0;
        timer_f = 0f;
        
    }
    void UpdateScore()
    {
        resttime.text = "ÁÙ³Ñ" + (180 - timer_i) + "¬í";
    }
}
