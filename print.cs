using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class print : MonoBehaviour
{
    public Button TestPrintButton;
    public Text myText;
    // Start is called before the first frame update
    void Start()
    {
        TestPrintButton.GetComponent<Button>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PrintOnClick(){
        myText.text="hello ";
    }
}
