using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_LifeComponent : MonoBehaviour
{//Calcula en numero de vidas del enemigo y actua en consecuencia.
    #region references
    GameManager _mygameManager;
    
    
    #endregion
    #region properties
    //desde vista del programador

    #endregion
    #region methods
    public void Damage()
    {
        //this es para referirse al script en el que  estás
        Destroy(this.gameObject);
        
        


    }
    #endregion
    #region parameters 
    //parametros es desde vista del diseñador
    public int m_NumeroVidas = 2;
    private int _Points = 100;
    #endregion

    //Para que se le quite 1 vida cada vez que colisione con un GO cuyo script sea ShotMovementController = bala
    void OnTriggerEnter2D(Collider2D collision)
    {   //si es una bala y lleva el layer Jugador
        if(collision.gameObject.GetComponent<ShotMovementController>()&& collision.gameObject.layer == 8)
        {
            
            m_NumeroVidas = m_NumeroVidas - 1;

            if (m_NumeroVidas == 0)
            {
                _mygameManager.OnEnemyDies(_Points);
                Destroy(this.gameObject);
                
            }
        }  
    }
    void Start()
    {
        //manera de asociar scripts de GameManager
        _mygameManager = GameManager.GetInstance();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
