using UnityEngine;

public class Retrovisor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    [SerializeField] GameObject retrovis;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          if (Input.GetKeyDown(KeyCode.R)){

            retrovis.SetActive(true);
            Debug.Log("lo reconoce");
        }
        
        if (Input.GetKeyUp(KeyCode.R)){

            retrovis.SetActive(false);
        }
    }
}
