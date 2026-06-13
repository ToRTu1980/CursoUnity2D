using UnityEngine;

namespace Player
{
    public class MovimientoPlayer : MonoBehaviour
    {
        //Direccion del movimiento
        private int movimientoHorizontal = 0;
        private int movimientoVertical = 0;
        private Vector2 mov = new(0, 0);

        //Velocidad inicial del movimiento, se puede modificar desde el inspector de Unity

        [SerializeField] 
        private float baseSpeed = 100f;
        [SerializeField] 
        private float sprintMultiplier = 1.5f;
        [SerializeField] 
        private float acceleration = 2f; // qué tan rápido sube/baja

        private float currentSpeed;
        private Rigidbody2D rb;

        public float vida = 100f;

        void Start()
        {
            //Obtengo las propiedades del RigidBody de mi objeto, para eso lo asigno a una variable
            rb = GetComponent<Rigidbody2D>();
            //Guardo la velocidad por defecto para poder volver a ella después de sprintar
            currentSpeed = baseSpeed;
        }

        //Update es llamado una vez por frame, es el lugar ideal para detectar inputs del usuario
        void Update()
        {
            Sprint();
            MovH();
            MovV();
        }

        void FixedUpdate()
        {
            //Asignamos la variable que determina la direccion
            mov = new Vector2(movimientoHorizontal, movimientoVertical);
            //Normalizamos el vector, hace que el movimiento sea igual en todas las direcciones, sin importar si es diagonal o recta
            mov = mov.normalized;
            //Empujamos al objeto en la direccion que le asignamos, multiplicado por la velocidad y por el tiempo que tarda en actualizarse el FixedUpdate
            rb.velocity = (currentSpeed * Time.fixedDeltaTime * mov);
        }

        //Movimiento horizontal
        private void MovH() { 
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
                movimientoHorizontal = 1;       //Derecha
            } else if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
                movimientoHorizontal = (-1);    //Izquierda
            } else {                            
                movimientoHorizontal = 0;       //Quieto    
            }
        }

        //Movimiento vertical
        private void MovV()
        {
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) { 
                movimientoVertical = 1;         //Arriba
            } else if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) { 
                movimientoVertical = (-1);      //Abajo
            } else { 
                movimientoVertical = 0;         //Quieto
            }
        }

        private void Sprint()
        {
            if (Input.GetKey(KeyCode.LeftShift)) // mientras esté presionado
            {
                // Aumenta gradualmente hasta baseSpeed * sprintMultiplier
                currentSpeed = Mathf.MoveTowards(currentSpeed, baseSpeed * sprintMultiplier, acceleration * Time.fixedDeltaTime);
            }
            else
            {
                // Vuelve gradualmente a la velocidad base
                currentSpeed = Mathf.MoveTowards(currentSpeed, baseSpeed, acceleration * Time.fixedDeltaTime);
            }
        }
    }
}
