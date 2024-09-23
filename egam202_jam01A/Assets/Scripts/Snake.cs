using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Snake : MonoBehaviour
{
    public GameObject restartButton;
    public Timing timer;


    Image snakeLife;

    float maxLife = 5f;
    public float lifeLeft;

    // Start is called before the first frame update
    void Start()
    {
        snakeLife = GetComponent<Image>();
        lifeLeft = maxLife;
    }

    // Update is called once per frame
    void Update()
    {

        snakeLife.fillAmount = lifeLeft / maxLife;

        if(lifeLeft < 1)
        {
            timer.TimeStop = 1;   
            restartButton.SetActive(true);
        }

    }

}
