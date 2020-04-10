using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreTextScript : MonoBehaviour
{
    // Start is called before the first frame update
    Text text;
    public static int coinAmount;

    void Start()
    {
        text = GetComponent<Text>();
        if (coinAmount > 0)
        {
            coinAmount = 0;
        }
    }

    void Update()
    {
        text.text = coinAmount.ToString();
        if (coinAmount == 25)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            
            
        }
    }

    
}
