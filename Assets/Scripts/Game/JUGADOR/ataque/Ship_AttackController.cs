using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship_AttackController : MonoBehaviour
{//Instancia la orden de disparo en escena cada vez que recibe la orden de disparar.
    #region references
    GameObject myShot;
    public GameObject Shot;
    public GameObject p_Shot;
    public bool autoshoot;
    public bool enemy;
    public int cadencia;
    #endregion
    #region properties
    #endregion
    #region methods
    public void Shoot()
    {//instanciamos el gameObject Shot en la posición del cañon p_Shot y con rotacion normal , congelamos los ejes X,Y;

       GameObject g= Instantiate<GameObject>(Shot, myShot.transform.position, Quaternion.identity);
        if(enemy)
            g.GetComponent<ShotMovementController>().m_ShotSpeed = -2;
    }
    #endregion
    #region parameters 


    #endregion
    // Start is called before the first frame update
    void Start()
    {
        //Para asociar a mi GO p_shot
        myShot = p_Shot;
        if (autoshoot){
            InvokeRepeating("Shoot", cadencia, cadencia);
        }
    }
    
}
