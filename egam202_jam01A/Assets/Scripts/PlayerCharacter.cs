using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    public GameObject tree;
    public Snake snake;

    public Timing timer;

    private Renderer rendererA;
    private Renderer rendererB;

    private float life;

    Color chameleonColor;
    Color treeColor;

    // Start is called before the first frame update
    void Start()
    {

     
        rendererA = this.gameObject.GetComponent<Renderer>();
        rendererB = tree.GetComponent<Renderer>();


    }

    // Update is called once per frame
    void Update()
    {
        chameleonColor = rendererA.material.color;
        treeColor = rendererB.material.color;

        if (Time.timeScale == 0 && !timer.isChecking)
        {
            work();
            Debug.Log(snake.lifeLeft);
        }

    }

    void work() 
    {
        if(colorCompare(chameleonColor, treeColor))
        {
            snake.lifeLeft = snake.lifeLeft - 1;
        } 
        else
        {

        }
    }


    bool colorCompare(Color c1, Color c2)
    {
        return c1.Equals(c2);
    }


}
