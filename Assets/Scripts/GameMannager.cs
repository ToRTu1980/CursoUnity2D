using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Singleton para acceder fácilmente desde cualquier script
    public static GameManager Instance;

    //Variable publica para la vida del jugador, se puede modificar desde el inspector de Unity
    public float vidaPlayer = 100f;

    void Awake()
    {
        // Evita que se duplique el GameManager al regresar a esta escena
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

