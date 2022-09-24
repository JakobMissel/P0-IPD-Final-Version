using System;
//Skal bruges til "TextMeshProGUI"
using TMPro;
//Unity ting
using UnityEngine;
using UnityEngine.UI;
//Den der g�r s� vi kan skifte scene
using UnityEngine.SceneManagement;


public class questionManager : MonoBehaviour
{

    public static questionManager instance;

    //Holder styr p� hvilket sp�rgsm�l vi er p� (ved brug af hel tal(Sp�rgsm�l 1 eller 2 eller 3))
    public int questionIndex;

    //Laver en knaplliste
    public TextMeshProUGUI[] button;
    //Siden vi har flere knapper laver vi en liste s� vi kan spare kode
    public Image[] buttonImage;

    //Billede til background (Det her er for at lave en plads til et normalt billede i unity)
    public Image background;
    //Siden vi har flere baggrunde (en for hvert sp�rgsm�l) bliver vi n�dt til at smide det i en liste s� vi kan skifte mellem
    public Sprite[] backgroundListe;
    //Samme ide som background og backgroundListe
    public Image progressbar;
    public Sprite[] progressbarList;

    //Viser sp�rgsm�let
    public TextMeshProUGUI questionDisplay;
    //Laver en liste til vores sp�rgsm�l
    public questionsRow[] questions;

    //Fort�ller hvilken scene der er vores slutsk�rm
    int endScene = 2;
    // Start is called before the first frame update
    void Start()
    {
        displayUpdate();



    }

    // Update is called once per frame
    void Update()
    {

    }

    public void displayUpdate()
    {
        for (int i = 0; i < button.Length; ++i)
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
//Serializable G�r s� Unity genkender class'en
[Serializable]
//Laver en stor unity dropdown menu  som vi bruger til at lave et sp�rgsm�l og skrive deres svar
//(det her er en klasse, vi har ikke l�rt om det her endnu, men forstil jer at det er et blueprint til et hus, et hus kr�ver forskellige elementer (en d�r, vindue, d�r osv.) det her holder styr p� tingene huset skal bruge)
public class questionsRow
{
    //G�r s� vi kan skrive sp�rgsm�lene
    public string question;
    //Laver en question lsite (bruger klassen under til det, s� den ved hvad listen skal bruge (blueprint!)) s� programmet kan holde styr p� hvilken du har klikket p� (vi g�r det p� den her m�de for at f� det som tal,)
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
