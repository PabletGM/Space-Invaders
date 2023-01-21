using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipInputComponent : MonoBehaviour
{//Da la orden de disparar y se encarga del movimiento de la nave
    #region properties

    [SerializeField]
    float x, y;
    Vector3 dir;
    
    private int i = 0;
    bool recargado = true;


    #endregion
    #region methods
    public void SetMovementDirection()
    {
        //Detectar los inputs WASD, en base a ellos componer la dirección del
        //movimiento.Llamar al método SetMovementDirection del componente
        //ShipMovementController

        //INPUT DE JUGADOR


        dir = new Vector3(x, y, -10);
        _myShipMovementComponent.SetDirection(dir);
    }
    #endregion
    #region parameters 

    
    private int _esperarecarga = 2;
    #endregion
    #region references
    ShipMovementComponent _myShipMovementComponent;
    Ship_AttackController _myShip_AttackController;
    #endregion





    //Asocia el input de usuario con el movimiento y el ataque
    void Start()
    {
        _myShipMovementComponent = GetComponent<ShipMovementComponent>();
        _myShip_AttackController = GetComponent<Ship_AttackController>();
       
    }

    //Asociamos ejes X e Y a dos variables y al pulsar espacio instanciamos una bala
    void Update()
    {
        x = Input.GetAxis("Horizontal");
        y = Input.GetAxis("Vertical");
        SetMovementDirection();

        if (Input.GetKeyDown("space")&&recargado)
        {    
                //accedemos a la instancia de bala cuando pulsamos espacio
                _myShip_AttackController.Shoot();   
        }
    }
    
    
}
