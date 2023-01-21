using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldVerticalDeadlineComponent : MonoBehaviour
{//comprobar constantemente en el update la posicion "y" de la squad , así cuando llegue a un limite establecido destruimos nuestras hordas
    #region references
    SquadMovementComponent _mySquadposition;
    GameManager _myGameManager;
    
    #endregion
    #region properties

    #endregion
    #region methods
    #endregion
    #region parameters 
    public float m_limiteDestruccion = -10;

    #endregion
    




    void Start()
    {
        _mySquadposition = GetComponent<SquadMovementComponent>();
        _myGameManager = GameManager.GetInstance();
    }

    // Update is called once per frame
    void Update()
    {
        if (m_limiteDestruccion >= transform.position.y)
        {
            
            Destroy(this.gameObject);
            _myGameManager.OnEnemyReachesBottomline();
            
            
        }
    }
}
