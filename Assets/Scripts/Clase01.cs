using UnityEngine;

public class Clase01 : MonoBehaviour
{
    public float vida = 100;
    public string nombre = "Player 1";
    //private bool estoyVivo = false;

    // Start is called before the first frame update
    void Start()
    {
        //int daño; // Variable local
        //estoyVivo = true; // Inicialización de la variable de estado

        Debug.Log("¡Bienvenido al juego, " + nombre + "!"); // Saludo al jugador
        print("Tu vida inicial es: " + vida); // Mostrar la vida inicial
    }
}
