using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour
{

    public GameObject playerCharacter;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = playerCharacter.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPressed()
    {
        sr.material.color = Color.green;
    }

}
