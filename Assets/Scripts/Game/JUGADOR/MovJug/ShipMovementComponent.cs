using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMovementComponent : MonoBehaviour
{//Permite el desplazamiento de la nave del jugador
    #region properties
    Vector3 dir; 
    #endregion
    #region methods
    //guardamos la direccion calculada en Ship_InputComponent
    public void SetDirection(Vector3 movementDirection)
    {
        
        dir = movementDirection;
        dir.z = 0;


    }
    #endregion
    #region parameters 
    public int m_velocidadPlayer;

    #endregion
    #region references
    ShipInputComponent m_shipInputComponent;
    #endregion



    
    void Start()
    { 
        //Player = GetComponent<Rigidbody2D>();
        m_shipInputComponent = GetComponent<ShipInputComponent>();
        //iniciamos variables  
    }

   //Para hacer el movimiento con la direccion y la velocidad del Player
    void Update()
    {
        transform.Translate(dir * m_velocidadPlayer * Time.deltaTime);
    }
    
    
}
