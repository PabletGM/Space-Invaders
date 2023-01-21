using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    //si hay una colision de un GO con el script Enemy_LifeComponent, se trata de un enemigo , fin de la partida

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
    private void OnTriggerEnter2D(Collider2D collision)
    {//Para asegurarse que cada enemigo muere

       
        if (collision.gameObject.GetComponent<Enemy_LifeComponent>())
        {

            _myGameManager.OnEnemyReachesBottomline(); 
        }
    }
}
