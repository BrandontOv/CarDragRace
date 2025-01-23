using System;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerVueltas : MonoBehaviour
{

    [SerializeField] GameObject Meta;
    [SerializeField] int checkpoints = 0;
    [SerializeField] int lap = 0;

    [SerializeField] GameObject check1;
    [SerializeField] GameObject check2;
    [SerializeField] GameObject check3;
    [SerializeField] GameObject check4;

    [SerializeField] GameObject Pause;
    [SerializeField] GameObject Win;

    [SerializeField] TMP_Text TxtLap;


    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lap == 3){

            Debug.Log("Acabaste");
            Win.SetActive(true);

            Invoke("creditos",2);

        }
      
      if(Input.GetKeyDown (KeyCode.Escape)){

                Pause.SetActive(true);
                Time.timeScale = 0;

                Debug.LogWarning("sebbugea");
            }

            TxtLap.text = "Vueltas 3/ " + lap;
        
    }

      void OnTriggerEnter (Collider other){

            if (other.tag == "Meta")
            {
                check1.SetActive (true);
                check2.SetActive (true);
                check3.SetActive (true);
                check4.SetActive (true);
            }
         

            

            if (other.gameObject.tag == "check1"){

                 Invoke("sumarchecks",2);
                check1.SetActive (false);
                Debug.Log("check1");

            }

            if (other.gameObject.tag == "check2")
            {

                Invoke("sumarchecks",2);
                check2.SetActive (false);
                Debug.Log("check2");
            }

            if(other.gameObject.tag == "check3")
            {

                Invoke("sumarchecks",2);
                check3.SetActive (false);
                Debug.Log("check3");
            }

            if(other.gameObject.tag =="check4")
            {

                Invoke("sumarchecks",2);
                check4.SetActive (false);
                Debug.Log("check4");
            }

        }

        void sumarchecks(){

            checkpoints++;
        }

        void reactivemeta(){
            Meta.SetActive (true);
            
        }

       void  OnTriggerExit(Collider other)
        {

            if(other.gameObject.tag == "Meta"&&checkpoints ==  4 ||other.gameObject.tag == "Meta"&&checkpoints ==  8 || other.gameObject.tag == "Meta"&&checkpoints ==  12)
            {
                lap++;

                Debug.Log("Vuelta:"+lap+"/3");
                Meta.SetActive (false);
                Invoke("reactivemeta",2);
                checkpoints=0;

            }
            if (other.gameObject.tag=="Fixer"&& checkpoints >=4){

                checkpoints = 4;
            }

        }

        void creditos(){

            SceneManager.LoadScene("Creditos");
            Time.timeScale = 1;
            Debug.Log("");
        }

        
        
}
