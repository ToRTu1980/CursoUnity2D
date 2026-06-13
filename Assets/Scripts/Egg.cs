using UnityEngine;

public class Egg : MonoBehaviour
{
    [SerializeField] 
    private Timer timer;

    private bool eggOn = false;

    // Update is called once per frame
    void Update()
    {
        if (eggOn && timer.tiempoRestante <= 0)
        {
            eggOn = true;
            Debug.Log("¡El huevo ha sido activado!");
        }
    }
}
