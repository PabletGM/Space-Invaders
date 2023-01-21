using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquadMovementComponent : MonoBehaviour
{//movimiento inicial y normal de la squad
    #region references
    #endregion
    #region properties
    private float _initialdirection;
    private float _y;//para poder acceder a ella
    #endregion
    #region methods
    public void AumentoVelocidad()
    {
        Debug.Log("Aumento de velocidad , cuidado!");
        m_velocidadBajada += 0.001f;
    }
    #endregion
    #region parameters 
   
    public float m_velocidadBajada;
    //diametro que alcanza en el movimiento
    private float _amplitude = 2;
    //velocidad en hacer el movimiento horizontal
    private float _frequency = 1.5f;

    #endregion

    
    

    //Creamos la direccion inicial para que sea 1 o -1 , si sale 0 , se pone a -1
    void Start()
    {
        InvokeRepeating("AumentoVelocidad", 1f, 5f);
       
        _initialdirection = Random.Range(0, 2);

        if(_initialdirection ==0)
        {
            _initialdirection = -1;
        }
        
    }

    
    void Update()
    {
        //el valor de x está entre -1 y 1 y se actualiza de manera constante de el tiempo real , si le multiplicamos por frequency aceleramos o frenamos este y la amplitud es el diametro del movimiento
        
        float x = Mathf.Cos(Time.time * _frequency) *_amplitude*_initialdirection ;
         _y = transform.position.y;
       

        //el transform.position es para que se vea con el fondo y esté delante
        transform.position = new Vector3(x, _y-m_velocidadBajada,0);

        
    }
    
}
