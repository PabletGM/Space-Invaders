using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeTimeController : MonoBehaviour
{
    //LifetimeController: Destruye el objeto después de cierto tiempo configurable LifeTime, si la bala no se destruye al impactar contra un GO enemigo

    #region references
    #endregion
    #region properties

    #endregion
    #region methods
    #endregion
    #region parameters 
    public int m_LifeTime;
    #endregion 
    
    void Start()
    {
        
    }

    //Destruye el gameObject bala en un periodo de tiempo del LifeTime, si antes no se choca con un enemigo
    void Update()
    {

        
        { 
            Destroy(this.gameObject, m_LifeTime);
        }

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
