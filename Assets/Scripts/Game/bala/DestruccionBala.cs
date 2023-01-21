using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionBala : MonoBehaviour
{
    //La bala se destruye si toca un GO que es el enemigo 
    #region references
    #endregion
    #region properties

    #endregion
    #region methods
    #endregion
    #region parameters 


    #endregion
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(this.gameObject);
    }
}
