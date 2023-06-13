using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    public Text kyoriLabel;
    int kyori;

    public Image timeGauge;

    float lastTime;

    // Start is called before the first frame update
    void Start()
    {
        kyori = 0;
        lastTime = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        lastTime -= Time.deltaTime;
        timeGauge.fillAmount = lastTime / 100f;

        if(lastTime<0)
        {
            SceneManager.LoadScene("GameScene");
        }

        kyori++;
        kyoriLabel.text = kyori.ToString("D6")+"km";
    }
}
