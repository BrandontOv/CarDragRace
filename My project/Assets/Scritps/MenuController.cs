using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
  [SerializeField] GameObject Menupa;
 public void conti(){

    Menupa.SetActive(false);
    Time.timeScale = 1;

 }

 public void Reini(){

    SceneManager.LoadScene("Lvl1");
    Time.timeScale =1;
 }

 public void Main(){

    SceneManager.LoadScene("Menu");
 }

 public void Credi(){
    SceneManager.LoadScene("Creditos");

 }
}
