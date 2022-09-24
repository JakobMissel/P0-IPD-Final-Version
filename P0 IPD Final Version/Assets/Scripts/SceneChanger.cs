using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    //
    private int nextScreen;

   


    questionManager myObj = new questionManager();
    // Start is called before the first frame update
    void Start()
    {
        //S�tter vores int nextScreen til at se ind i unity og sige at den skal g� en op i vores build (I kan se vores build ved at g� op i filer og klikke build settings)
        nextScreen = SceneManager.GetActiveScene().buildIndex + 1;
        Debug.Log("mit scnene lige nu er: " + SceneManager.GetActiveScene().buildIndex + 1);

    }

    // Update is called once per frame
    void Update()
    {


    }

    //F�r en til n�ste slide
    public void nextslide()
    {
        SceneManager.LoadScene(nextScreen);



    }
    //F�r en til tidligere slide, hvis man ikke har svaret p� et sp�rgsm�l endnu. F�r en til tidligere sp�rgsm�l hvis man har svaret p� et.
   
    public void prevquestion()
    {
        questionManager callQuestionManager = GameObject.Find("Manager").GetComponent<questionManager>();
        if (manager.instance.questionAnswerList.Count == 0)
        {
            SceneManager.LoadScene(0);
        }
        else
        {
            manager.instance.questionAnswerList.RemoveAt(manager.instance.questionAnswerList.Count - 1);
            callQuestionManager.questionIndex--;
            callQuestionManager.displayUpdate();


        }
    }
   
    //F�r en til f�rste slide og fjerner alle svarende fra vores array

    public void backToBasics()
    {


        SceneManager.LoadScene(0);
        manager.instance.questionAnswerList.Clear();
    }


}
