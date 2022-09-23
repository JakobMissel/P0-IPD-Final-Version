using System;
//Skal bruges til "TextMeshProGUI"
using TMPro;
//Unity ting
using UnityEngine;
using UnityEngine.UI;
//Den der gør så vi kan skifte scene
using UnityEngine.SceneManagement;

public class questionManager : MonoBehaviour
{
    //Holder styr på hvilket spørgsmål vi er på (ved brug af hel tal(Spørgsmål 1 eller 2 eller 3))
    int questionIndex;

    //Laver en knaplliste
    public TextMeshProUGUI[] button;
    //Siden vi har flere knapper laver vi en liste så vi kan spare kode
    public Image[] buttonImage;

    //Billede til background (Det her er for at lave en plads til et normalt billede i unity)
    public Image background;
    //Siden vi har flere baggrunde (en for hvert spørgsmål) bliver vi nødt til at smide det i en liste så vi kan skifte mellem
    public Sprite[] backgroundListe;
    //Samme ide som background og backgroundListe
    public Image progressbar;
    public Sprite[] progressbarList;

    //Viser spørgsmålet
    public TextMeshProUGUI questionDisplay;
    //Laver en liste til vores spørgsmål
    public questionsRow[] questions;

   //Fortæller hvilken scene der er vores slutskærm
    int endScene=2;
    // Start is called before the first frame update
    void Start()
    {
        displayUpdate();
    
    
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void displayUpdate()
    {
        for(int i = 0; i < button.Length; ++i)
        {
            buttonImage[i].sprite = questions[questionIndex].questions[i].buttonImage;
            button[i].text = questions[questionIndex].questions[i].answer;
            

        }
        questionDisplay.text = questions[questionIndex].question;
        background.sprite = backgroundListe[questionIndex];
        progressbar.sprite = progressbarList[questionIndex];
    }
    //Gemmer hvor langt vi er 
    public void buttonClick(int i)
    {
        manager.instance.questionAnswerList.Add(i);
        questionIndex++;
        if (questionIndex >= questions.Length)
        {
            SceneManager.LoadScene(endScene);
            
        }
        else
        {
            displayUpdate();
        }

    }

}
//Serializable Gør så Unity genkender class'en
[Serializable]
//Laver en stor unity dropdown menu  som vi bruger til at lave et spørgsmål og skrive deres svar
//(det her er en klasse, vi har ikke lært om det her endnu, men forstil jer at det er et blueprint til et hus, et hus kræver forskellige elementer (en dør, vindue, dør osv.) det her holder styr på tingene huset skal bruge)
public class questionsRow
{
    //Gør så vi kan skrive spørgsmålene
    public string question;
    //Laver en question lsite (bruger klassen under til det, så den ved hvad listen skal bruge (blueprint!)) så programmet kan holde styr på hvilken du har klikket på (vi gør det på den her måde for at få det som tal,)
    public question[] questions;





}

[Serializable]
//Igen en klasse
public class question
{

    public string answer;
    public Color answerColor;
    public Sprite buttonImage;


}