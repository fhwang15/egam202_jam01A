using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class givenColor : MonoBehaviour
{

    public Timing timer;
    public GameObject tree;
    SpriteRenderer sr;



    bool colorChange;

    // Start is called before the first frame update
    void Start()
    {
        sr = tree.GetComponent<SpriteRenderer>();
        colorChange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale > 0)
        {
            colorChange = false;
        }
        else
        {
            colorChange = true;
        }

        nextColor(colorChange);
    }

    void nextColor(bool changeable)
    {

        int randomNumber = Random.Range(1, 3);

        if (colorChange)
        {
            if (randomNumber == 1)
            {
                sr.material.color = Color.red;
            }
            else if (randomNumber == 2)
            {
                sr.material.color = Color.blue;
            }
            else if (randomNumber == 3)
            {
                sr.material.color = Color.green;
            }

            colorChange = false;
        }
        else
        {
            return;
        }
    }

 }