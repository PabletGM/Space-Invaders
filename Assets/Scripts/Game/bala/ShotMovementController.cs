using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMovementController : MonoBehaviour
{//Movimiento de la bala rectilineo
    #region properties
    
    Vector2 movimiento;
    #endregion
    #region methods
    #endregion
    #region parameters 
    public float m_ShotSpeed;

    #endregion
    #region references
    Rigidbody2D _mybala;
    #endregion



    //Ponemos un movimiento de la bala rectilineo ascendente en eje Y y asociamos Rigidbody bala
    void Start()
    {
        _mybala = GetComponent<Rigidbody2D>();
        movimiento = new Vector2(0, 10);
    }

    
    void Update()
    {
        
    }
    //Para el movimieto de la bala porque hay colision utilizamos void.FixedUpdate()
     void FixedUpdate()
     {
        _mybala.velocity = movimiento * m_ShotSpeed;
     }
}
