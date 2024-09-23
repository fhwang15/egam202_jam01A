using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButton : MonoBehaviour
{
    SpriteRenderer sr;
    public GameObject playerCharacter;


    // Start is called before the first frame update
    void Start()
    {
        sr = playerCharacter.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnPressed()
    {
        sr.material.color = Color.red;
    }
}
