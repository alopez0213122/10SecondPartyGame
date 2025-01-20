using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class TimerText : MonoBehaviour
{
    public int timeLeft = 10;
    public Text countdown;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        countdown.text = ("" + timeLeft);
        if (timeLeft <= 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
