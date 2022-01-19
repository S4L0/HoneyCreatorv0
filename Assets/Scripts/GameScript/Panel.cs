using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Panel : MonoBehaviour
{
    public Button btnmute;
    public Button btnquit;
    public Button btnretry;
    public Button btnback;
    public Sprite NoMuteImage;
    public Sprite MuteImage;
    bool MuteImageConrtol = true;
    private bool ESCcontrol = false;
    public GameObject pnl;
    public GameObject bee;
    

    public void Retry()
    {
        
        pnl.SetActive(false);
        SceneManager.LoadScene("Game");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Mute()
    {
        if (MuteImageConrtol)
        {
            btnmute.image.sprite = NoMuteImage;
            MuteImageConrtol = false;
        }
        else
        {
            btnmute.image.sprite = MuteImage;
            MuteImageConrtol = true;
        }
    }
    public void backmenu()
    {
        SceneManager.LoadScene("Menu");
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&& ESCcontrol == false)
        {
            pnl.SetActive(true);
            ESCcontrol = !ESCcontrol;
            Time.timeScale = 0;
        }
        else if(Input.GetKeyDown(KeyCode.Escape)&& ESCcontrol != false)
        {
            pnl.SetActive(false);
            ESCcontrol = !ESCcontrol;
            Time.timeScale = 1;
        }

        if(bee.transform.position.y>16 || bee.transform.position.y< -16)
        {
            pnl.SetActive(true);
            bee.SetActive(false);
        }
        
    }
}
