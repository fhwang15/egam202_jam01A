using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class givenColor : MonoBehaviour
{

    public Timing timer;
    public GameObject tree;
    SpriteRenderer sr;

    int changeInt;

    // Start is called before the first frame update
    void Start()
    {
        sr = tree.GetComponent<SpriteRenderer>();
        changeInt = Random.Range(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Time.timeScale == 0 && !timer.isChecking)
        {
            nextColor();
        }

        showColor();

    }


    int nextColor()
    {
        int randomNumber = Random.Range(1, 4);
        timer.isChecking = true;

        return changeInt = randomNumber;
    }

    void showColor()
    {
        
        if (changeInt == 1)
        {
            sr.material.color = Color.red;
        }
        else if (changeInt == 2)
        {
            sr.material.color = Color.blue;
        }
        else if (changeInt == 3)
        {
            sr.material.color = Color.green;
        }

    }

 }