using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject reset;

    // Start is called before the first frame update
    void Start()
    {
        reset.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void OnPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        reset.SetActive(false);
    }

}
