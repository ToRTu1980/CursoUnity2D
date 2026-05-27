using UnityEngine;

public class Timer : MonoBehaviour
{
    public float tiempoRestante = 10f; // tiempo inicial
    public bool timerOn = false;

    void Update()
    {
        if (timerOn) 
        {
            TimerCheck();
        }
    }

    private void TimerCheck()
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
