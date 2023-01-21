using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_LifeComponent : MonoBehaviour
{
    //Se encarga de matar al jugador si recibe una colisión activando el GameManager
    #region references
    GameManager _myGameManager;
    #endregion
    #region properties

    #endregion
    #region methods
    #endregion
    #region parameters 


    #endregion
    

    void Start()
    {
        _myGameManager = GameManager.GetInstance();
    }

    
    void Update()
    {
        
    }

    //Si el jugador se choca con un enemigo activa el GameOver
    private void OnTriggerEnter2D(Collider2D collision)
    {
        _myGameManager.OnPlayerDies();
    }
}
