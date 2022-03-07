using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreScript : MonoBehaviour
{
    // Start is called before the first frame update
    public Text score;
    public Text Hscore;
    int scorev;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        highScore();
        Hscore.text =PlayerPrefs.GetInt("Hscore").ToString();
    }

    public void Play(){
    scorev=scorev+1;
    score.text = scorev.ToString();
    PlayerPrefs.SetInt("score",scorev);
    }

    public void highScore(){
        if(PlayerPrefs.GetInt("score",scorev)>PlayerPrefs.GetInt("Hscore")){
            int h = PlayerPrefs.GetInt("score");
            PlayerPrefs.SetInt("Hscore",h);

        }
    }
}
