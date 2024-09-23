using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timing : MonoBehaviour
{
    Image timer;
    float maxTime = 5f;
    float timeLeft;

    float delayTime = 3f;
    public bool isChecking;

    public int work;

    // Start is called before the first frame update
    void Start()
    {
        
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
