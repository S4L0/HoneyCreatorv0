using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class panelScript : MonoBehaviour
{
    public Text txtfo;
    public Button btnPlay;
    public Slider slider;
    public Image image;
    public Sprite easy;
    public Sprite hard;
    public Sprite master;
  

    public void Play()
    {
        if (slider.value <= 1)
        {
            SceneManager.LoadScene("Game");
            HexCreate.HexCount = Random.Range(1, 7);
            FlowerCreator.FlowerCount = HexCreate.HexCount-1;
            Debug.Log("easy");
            
        }
        else if (slider.value >1 && slider.value <= 2)
        {
            SceneManager.LoadScene("Game");
            HexCreate.HexCount = Random.Range(7, 14);
            FlowerCreator.FlowerCount = HexCreate.HexCount;
            Debug.Log("hard");
            
        }
        else if(slider.value>2)
        {
            SceneManager.LoadScene("Game");
            HexCreate.HexCount = Random.Range(14, 21);
            FlowerCreator.FlowerCount = HexCreate.HexCount-1;
            Debug.Log("master");
            
        }

    }


    public void SliderImage()
    {
        if (slider.value <= 1)
        {
            image.sprite = easy;
            txtfo.text = "1 dahil 7 arasında çiçek üretir.EASY";
        }
        else if (slider.value > 1 && slider.value <= 2)
        {
            image.sprite = hard;
            txtfo.text = "7 dahil 14 arasında çiçek üretir.HARD";
        }
        else
        {
            image.sprite = master;
            txtfo.text = "14 dahil 21 arasında çiçek üretir.MASTER";
        }
    }
    
    void Update()
    {
        SliderImage();
    }
}
