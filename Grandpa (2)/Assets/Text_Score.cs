﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_Score : MonoBehaviour
{
    public Text t_score;
    public static int Score = 5;
    // Start is called before the first frame update
    void Start()
    {
        t_score.text = "Family" + Score.ToString() ;
    }

    // Update is called once per frame
    void Update()
    {
        t_score.text = "Family :" + Score.ToString();

    }
}
