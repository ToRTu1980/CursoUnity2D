using UnityEngine;

public class Egg : MonoBehaviour
{
    private bool eggOn = false;
    [SerializeField] private Timer timer;

    // Start is called before the first frame update
    void Start()
    {
    }

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
