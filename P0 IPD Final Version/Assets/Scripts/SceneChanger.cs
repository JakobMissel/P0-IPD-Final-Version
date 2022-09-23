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
        //S�tter vores int nextScreen til at se ind i unity og sige at den skal g� en op i vores build (I kan se vores build ved at g� op i filer og klikke build settings)
        nextScreen = SceneManager.GetActiveScene().buildIndex+1;
        prevScreen = SceneManager.GetActiveScene().buildIndex-1;
        Debug.Log("mit scnene lige nu er: "+ SceneManager.GetActiveScene().buildIndex+1);

    }

    // Update is called once per frame
    void Update()
    {


      }  
    
    //F�r en til n�ste slide
public void nextslide(){
    SceneManager.LoadScene(nextScreen);



}
    //F�r en til tidligere slide
    public void prevside(){

        SceneManager.LoadScene(prevScreen);
        
}
    //F�r en til f�rste slide

    public void backToBasics(){


        SceneManager.LoadScene(0);

}


}
