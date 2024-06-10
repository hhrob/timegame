using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDilation : MonoBehaviour
{
    public float slowMotionFactor = 0.5f;
    public float duration = 2f;

    private bool isTimeDilated = false;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B)  && !isTimeDilated)
        {
            StartCoroutine(SlowTime());
        }
    }

    IEnumerator SlowTime()
    {
        isTimeDilated = true;
        Time.timeScale = slowMotionFactor;
        yield return new WaitForSecondsRealtime(duration);
        Time.timeScale = 1f;
        isTimeDilated = false;
    }
}
