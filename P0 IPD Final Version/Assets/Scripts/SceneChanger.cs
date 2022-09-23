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
        nextScreen = SceneManager.GetActiveScene().buildIndex + 1;
        prevScreen = SceneManager.GetActiveScene().buildIndex - 1;
        Debug.Log("mit scnene lige nu er: " + SceneManager.GetActiveScene().buildIndex + 1);

    }

    // Update is called once per frame
    void Update()
    {


    }

    //Får en til næste slide
    public void nextslide()
    {
        SceneManager.LoadScene(nextScreen);



    }
    //Får en til tidligere slide, hvis man ikke har svaret på et spørgsmål endnu. Får en til tidligere spørgsmål hvis man har svaret på et.
   /*
    public void prevquestion()
    {
        if (manager.instance.questionAnswerList.Count == 0)
        {
            SceneManager.LoadScene(0);

        }
        else
        {
            print(manager.instance.questionAnswerList[]);
            // manager.instance.questionAnswerList.RemoveAt(manager.instance.questionAnswerList.Count);
            //print(manager.instance.questionAnswerList[manager.instance.questionAnswerList.Count]);
            print("jeff");
        }
    }
   */
    //Får en til første slide

    public void backToBasics()
    {


        SceneManager.LoadScene(0);
        manager.instance.questionAnswerList.Clear();
    }


}
