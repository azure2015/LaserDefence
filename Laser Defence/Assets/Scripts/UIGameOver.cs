using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoredText;

    ScoreKeeper scoreKeeper;


    void Awake()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Start()
    {
        scoredText.text = " You Scored:\n " + scoreKeeper.GetScore();    
    }


}
