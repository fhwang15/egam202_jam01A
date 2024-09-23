using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timing : MonoBehaviour
{
    public int TimeStop;

    public GameObject button;

    Image timer;
    float maxTime = 1f;
    float timeLeft;

    float delayTime = 1f;
    public bool isChecking;

    public int work;

    // Start is called before the first frame update
    void Start()
    {
        TimeStop = 0;

        if(TimeStop == 0)
        {
            Time.timeScale = 1;
        }


        timer = GetComponent<Image>();
        timeLeft = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timer.fillAmount = timeLeft / maxTime;
        }
        else
        {
            StartCoroutine(checking());  
        }

        if(TimeStop == 1)
        {
            Time.timeScale = 0;
        }


        Debug.Log(TimeStop);
    }

    IEnumerator checking()
    {

        Time.timeScale = 0;
        timeLeft = maxTime;
        isChecking = false;

        yield return new WaitForSecondsRealtime(delayTime);
        Time.timeScale = 1;
        isChecking = false;

        
    }

}
