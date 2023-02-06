using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnswerButtons : MonoBehaviour
{
    public GameObject answerCbackBlue;  // Blue is waiting
    public GameObject answerCbackGreen; // Green is correct
    public GameObject answerCbackRed; // Red is wrong


    public GameObject answerBbackBlue;  // Blue is waiting
    public GameObject answerBbackGreen; // Green is correct
    public GameObject answerBbackRed; // Red is wrong

    public GameObject answerAbackBlue;  // Blue is waiting
    public GameObject answerAbackGreen; // Green is correct
    public GameObject answerAbackRed; // Red is wrong

    public GameObject answerA;
    public GameObject answerB;
    public GameObject answerC;
    public GameObject nextQ;
    public Transform badgePos;
   
   


    private Vector3 Bagde = new Vector3(-451f, 888, 0);


    //public GameObject currentScore;
    //public int scoreValue;
    public GameObject tickCorrectPrefabs;
    public GameObject tickWrongPrefabs;
    public int badgeIndex;
    public GameObject wrongText;
    public GameObject correctText;
    public AudioSource correctFX;
    public AudioSource wrongFX;


    void  Start()
    {
       
    }
    

    public void AnswerC()
    {
        if (QuestionGenerate.actualAnswer == "C") 
        {
            answerCbackGreen.SetActive(true);
            answerCbackBlue.SetActive(false);
            correctText.SetActive(true);
            correctFX.Play();


            Instantiate(tickCorrectPrefabs, transform.position, badgePos.transform.rotation);

        }
        else
        {
            answerCbackRed.SetActive(true);
            answerCbackBlue.SetActive(false);
            wrongText.SetActive(true);
            wrongFX.Play();

            Instantiate(tickWrongPrefabs, transform.position, badgePos.transform.rotation);
            
        }
        answerC.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerA.GetComponent<Button>().enabled = false;
        
    }

    public void AnswerB()
    {
        if (QuestionGenerate.actualAnswer == "B")
        {
            answerBbackGreen.SetActive(true);
            answerBbackBlue.SetActive(false);
           
            correctText.SetActive(true);
            correctFX.Play();

            Instantiate(tickCorrectPrefabs, transform.position, badgePos.transform.rotation);

            
        }
        else
        {
            answerBbackRed.SetActive(true);
            answerBbackBlue.SetActive(false);
           
            wrongText.SetActive(true);
            wrongFX.Play();

            Instantiate(tickWrongPrefabs, transform.position, badgePos.transform.rotation);

           
        }
        answerC.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerA.GetComponent<Button>().enabled = false;
        
    }
    public void AnswerA()
    {
        if (QuestionGenerate.actualAnswer == "A")
        {
            answerAbackGreen.SetActive(true);
            answerAbackBlue.SetActive(false);
            correctText.SetActive(true);
            correctFX.Play();

            Instantiate(tickCorrectPrefabs, transform.position, badgePos.transform.rotation);

           
        }
        else
        {
            answerAbackRed.SetActive(true);
            answerAbackBlue.SetActive(false);
            wrongText.SetActive(true);
            wrongFX.Play();

            Instantiate(tickWrongPrefabs, transform.position, badgePos.transform.rotation);
        }
        answerC.GetComponent<Button>().enabled = false;
        answerB.GetComponent<Button>().enabled = false;
        answerA.GetComponent<Button>().enabled = false;
        
    }

    IEnumerator NextQuestion()
    {
        yield return new WaitForSeconds(1.5f);


        answerAbackGreen.SetActive(false);
        answerBbackGreen.SetActive(false);
        answerCbackGreen.SetActive(false);
        answerAbackRed.SetActive(false);
        answerBbackRed.SetActive(false);
        answerCbackRed.SetActive(false);
        answerAbackBlue.SetActive(true);
        answerBbackBlue.SetActive(true);
        answerCbackBlue.SetActive(true);
        /*tickCorrect.SetActive(false);*/
        correctText.SetActive(false);
        /*tickWrong.SetActive(false);*/
        wrongText.SetActive(false);
        answerC.GetComponent<Button>().enabled = true;
        answerB.GetComponent<Button>().enabled = true;
        answerA.GetComponent<Button>().enabled = true;
        QuestionGenerate.displayingQuestion = false;
    }

    public void NextQ()
    {
         StartCoroutine(NextQuestion());
        
    }

  /* public void Badges()
    {
        if (correctText == true)
        {
            Instantiate(tickCorrect, Bagde1Pos, BagdePrefab.transform.rotation);
        }
        else
        {
            Instantiate(tickWrong, Bagde1Pos, BagdePrefab.transform.rotation);
        }

    }*/
    
}
