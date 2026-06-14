using Player;
using UnityEngine;

public class DebugLog : MonoBehaviour
{
    public string nombreGamer = "Player 1";
    //private bool estoyVivo = false;

    // Start is called before the first frame update
    void Start()
    {

        //GameObject gnome = GameObject.Find("Gnome");
        //MovimientoPlayer classMovPlayer = gnome.GetComponent<MovimientoPlayer>();

        Debug.Log("¡Bienvenido al juego, " + nombreGamer + "!"); // Saludo al jugador
        print("Tu vida inicial es: " + GameManager.Instance.vidaPlayer); // Mostrar la vida inicial
    }
}
