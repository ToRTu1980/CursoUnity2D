using UnityEngine;

public class Clase3Mov : MonoBehaviour
{
    //Direccion del movimiento
    private int movimientoHorizontal = 0;
    private int movimientoVertical = 0;
    private Vector2 mov = new(0, 0);

    //Velocidad inicial del movimiento, se puede modificar desde el inspector de Unity
    [SerializeField] private float speed = 10;
    private Rigidbody2D rb;

    void Start()
    {
        //Obtengo las propiedades del RigidBody de mi objeto, para eso lo asigno a una variable
        rb = GetComponent<Rigidbody2D>();
    }

    //Update es llamado una vez por frame, es el lugar ideal para detectar inputs del usuario
    void Update()
    {
        //Movimiento horizontal
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) { 
            movimientoHorizontal = 1;           //Derecha
        } else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) { 
            movimientoHorizontal = (-1);        //Izquierda
        } else { 
            movimientoHorizontal = 0;           //Quieto
        }

        //Movimiento vertical
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) { 
            movimientoVertical = 1;             //Arriba
        } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) { 
            movimientoVertical = (-1);          //Abajo
        } else { 
            movimientoVertical = 0;             //Quieto
        }
    }

    void FixedUpdate()
    {
        //Asignamos la variable que determina la direccion
        mov = new Vector2(movimientoHorizontal, movimientoVertical);
        //Normalizamos el vector, hace que el movimiento sea igual en todas las direcciones, sin importar si es diagonal o recta
        mov = mov.normalized;
        //Empujamos al objeto en la direccion que le asignamos, multiplicado por la velocidad y por el tiempo que tarda en actualizarse el FixedUpdate
        //rb.velocity = (speed * Time.fixedDeltaTime * mov);

        // Ya no multiplicamos por fixedDeltaTime, la velocidad es directa
        rb.velocity = mov * speed;
    }
}
