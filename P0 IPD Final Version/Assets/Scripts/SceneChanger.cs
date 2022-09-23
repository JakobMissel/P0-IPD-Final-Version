using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    //
    private int nextScreen;
    private int prevScreen;
    // Start is called before the first frame update
    void Start()
    {
        //Sætter vores int nextScreen til at se ind i unity og sige at den skal gå en op i vores build (I kan se vores build ved at gå op i filer og klikke build settings)
        nextScreen = SceneManager.GetActiveScene().buildIndex+1;
        prevScreen = SceneManager.GetActiveScene().buildIndex-1;
        Debug.Log("mit scnene lige nu er: "+ SceneManager.GetActiveScene().buildIndex+1);

    }

    // Update is called once per frame
    void Update()
    {


      }  
    
    //Får en til næste slide
public void nextslide(){
    SceneManager.LoadScene(nextScreen);



}
    //Får en til tidligere slide
    public void prevside(){

        SceneManager.LoadScene(prevScreen);
        
}
    //Får en til første slide

    public void backToBasics(){


        SceneManager.LoadScene(0);

}


}
