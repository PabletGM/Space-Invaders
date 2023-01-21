using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{//Almacena la puntuacion , dictamina el fin del juego y crea las hordas enemigas
    #region referencies
    WorldVerticalDeadlineComponent _WorldVerticalDeadline;
    UIManager _UIManager;
    #endregion
    #region properties

    //private _minuscula y ya lo que quieres
    //publica m_bvqebvbnv
    //metodos primera letra en mayuscula por cada palabra que compone el metodo
   
    public bool _isGameRunning=true;
    
    static private GameManager _instance;//instancia unica del GameManager
    [SerializeField]
    GameObject[] _squads;
    public Text m_Scoretext;

    #endregion
    #region methods

    //para guardar la instancia
    static public GameManager GetInstance()
    {
        return _instance;
    }

    //Para asociar puntuacion acumulada con componente Texto 
    public  int Score()
    {

        m_Scoretext.text = m_score.ToString();
        //si la puntuacion llega a 1500
        if (m_score >= 1500)
        {
            //activamos pantalla de victoria
            _UIManager.Win();
        }
        return m_score;
    }

    //metodo llamado por los enemigos cuando mueren, recibiendo puntos a añadir a la puntuación y actualizando el valor Score, asi cuando se acceda al metodo Damage se le suma puntos accediendo a este método.
    public void OnEnemyDies(int scoreToAdd)
    {
       
        m_score = m_score + scoreToAdd;
        Debug.Log(m_score);
        //para actualizar el numero de puntos m_score
        Score();

    }

    public void OnEnemyReachesBottomline()
    {
       
        //si un enemigo llega a la un limite establecido, pierdes y sale panel de GameOver()
        if(_isGameRunning)
        {
            GameOver();
        }
       
    }
    //conecta con el UIManager y su metodo GameOver 
    public void GameOver()
    {
        _isGameRunning = false;
        _UIManager.GameOver();
        
    }
    
   
    //Conecta con el GameOver
    public void OnPlayerDies()
    {
        GameOver();
    }
    // Start is called before the first frame update
   
    #endregion
    #region parameters 
    float _temporizador = 5f;//temporizador para que se vayan instanciando nuevas squad

    int m_score = 0;

    #endregion

    //indica si el juego está o no en marcha

    void Awake()
    {
        if (_instance == null)
        {
            //asegurar que solo existe una sola instancia del GameManager
            _instance = this;
            //Evita que se destruya este objeto al cambiar de escena
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            //si hay mas de 1 instancia se destruye
            Destroy(this.gameObject);
        }
    }

    //Para asoiar script _UIManager
    private void Start()
    {
        _UIManager = GetComponent<UIManager>();
    }

    //Encargado de crear un squad cada 5 segundos
    void Update()
    {
       
        _temporizador -= Time.deltaTime ;

        if(_temporizador<=0&&_squads.Length!=0)
        {
            //defino una variable para aleatorio que contenga desde 0 a el numero de squads ya que por defecto le resta 1 , asi no hace falta quitarle la posicion del 0.

            //se instanciará en la posicion del GameManager
            int aleatorio = Random.Range(0, _squads.Length );
            //instanciamos la squad con el numero del array aleatorio en una posicion y rotacion concreta.
            Instantiate<GameObject>(_squads[aleatorio], transform.position, Quaternion.identity);
            //reinicias el temporizador para que vuelva a empezar la cuenta atrás
            _temporizador = 10f ;
        }
    }
}
