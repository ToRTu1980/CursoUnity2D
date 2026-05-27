using UnityEngine;

public class Timer : MonoBehaviour
{
    public float tiempoRestante = 10f; // tiempo inicial
    private bool timerOn;

    void Start()
    {
        timerOn = true;
    }

    void Update()
    {
        TimerCheck();
    }

    private void TimerCheck()
    {
        if (timerOn)
        {
            tiempoRestante -= Time.deltaTime;

            if (tiempoRestante > 0)
            {
                // Muestra el tiempo como Integer, sin decimales
                Debug.Log("Tiempo actual: " + Mathf.FloorToInt(tiempoRestante));
            }
            else
            {
                Debug.Log("Se terminó el tiempo!");
                tiempoRestante = 0;
                timerOn = false;
            }
        }
    }
}
