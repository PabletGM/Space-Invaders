using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{//Encargado de cambios de escena o activacion de paneles como GameOver o Score
    #region references
    public GameObject infoPanel;
    public Text Score;
    #endregion
    #region properties
    public GameObject m_gameOver;
    public GameObject m_player;
    public GameObject m_Win;
    public Text m_Scoretext;
    GameManager m_GameManager;
    private bool _gamerunning;
    
    #endregion
    #region methods

    //Para cargar la escena Game desde la escena de inicio
    public void ChangeSceneGame()
    {
        SceneManager.LoadScene("GAME");
    }

    //Para activar el panel GameOver , desactivar al jugador e invocar metodo Score
    public void GameOver()
    {

        m_gameOver.SetActive(true);
        m_player.SetActive(false);
        ScoreQuit();

    }
    public void Win()
    {
        m_Win.SetActive(true);

    }
    //Activa panel Score y conecta con el GameManager para guardar la puntuacion
    public void ScoreQuit()
    {
        infoPanel.SetActive(false);
    }
    
        #endregion
        #region parameters 
        #endregion

        void Start()
        {
            m_GameManager = GameManager.GetInstance();
            _gamerunning = m_GameManager._isGameRunning;


        }

    

}

