using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMain : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            Debug.Log("Sale del juego");
        }
    }

     public void Reini(){

    SceneManager.LoadScene("Lvl1");
    
 }

  public void Credi(){

    SceneManager.LoadScene("Creditos");
    
 }
}
