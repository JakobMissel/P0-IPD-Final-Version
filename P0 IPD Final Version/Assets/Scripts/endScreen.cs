//Bibloteker som g�r at man kan flere ting
using System.Collections;
using System.Collections.Generic;
//Skal bruges til "TextMeshProGUI"
using TMPro;
//Skal bruges til at f� Unity til at virke
using UnityEngine;
using UnityEngine.UI;

public class endScreen : MonoBehaviour
{
    //Laver en tekst liste til de forskellige konklusioner (Deres tekst er skrevet inde i unity)
    public string[] con1;
    public string[] con15;
    public string[] con2;
    public string[] con3;
    
    //En statisk tekst der altid st�r f�r ens usertype 
    public string usertypeIntro;
   //Selve meme bileldet
    public Image meme;
    //Memebillede liste (Liste bliver lavet med "[]")
    public Sprite[] memebillede;
   
    //G�r plads i Unity til at skrive tekst til de svar man har givet tidligere i quizzen
    public TextMeshProUGUI answerDisplay;
    public TextMeshProUGUI answerDisplay2;
    public TextMeshProUGUI answerDisplay3;

    //Ens usertype (bliver senere kombineret med "userTypeIntro")
    public TextMeshProUGUI userType;


    // Start is called before the first frame update
    void Start()
    {
        //manager.instance hiver fat i manager scriptet som er der hvor vi kan se hvad vi har svaret
        //Kombinere userTypeIntro med den usertype man f�r ud fra f�rste svar
        userType.text = usertypeIntro + con1[manager.instance.questionAnswerList[0]];
        //Henter meme billedet an p� hvad man svarede p� sp�rgsm�l 1
        meme.sprite = memebillede[manager.instance.questionAnswerList[0]];
        //Viser tekst fra f�rste sp�rgsm�l
        answerDisplay.text = con15[manager.instance.questionAnswerList[0]];



        //Viser tekst fra tredje sp�rgsm�l
        answerDisplay2.text = con2[manager.instance.questionAnswerList[1]];
        //Viser tekst fra trejde sp�rgsm�l
        answerDisplay3.text = con3[manager.instance.questionAnswerList[2]];



    }

    // Update is called once per frame
    void Update()
    {
        


    }





}
