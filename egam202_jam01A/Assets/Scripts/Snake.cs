using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snake : MonoBehaviour
{
    Image snakeLife;

    float maxLife = 5f;
    public float lifeLeft;

    // Start is called before the first frame update
    void Start()
    {
        lifeLeft = maxLife;
        snakeLife = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {

        snakeLife.fillAmount = lifeLeft / maxLife;

    }
}
