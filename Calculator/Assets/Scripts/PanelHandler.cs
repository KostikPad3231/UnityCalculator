using System;
using UnityEngine;
using UnityEngine.UI;
using NCalc;

public class PanelHandler : MonoBehaviour
{
    public Text panelText;

    void Start()
    {
        panelText = GameObject.Find("PanelText").GetComponent<Text>();
    }

    public void Clear()
    {
        panelText.text = "";
    }

    public void AddValue(string value)
    {
        if(value == @"\u221A")
        {
            value = "Sqrt";
        }
        panelText.text += value;
    }

    public void WriteAnswer()
    {
        Expression expression = new Expression(panelText.text);
        if(expression.HasErrors()){
            Debug.Log("The expression has syntax error: " + expression.Error);
        }
        else{
            try{
                panelText.text = expression.Evaluate().ToString().Replace(',', '.');
            }
            catch(EvaluationException e)
            {
                Debug.Log("Error during evaluation: " + e.Message);
            }
            catch(Exception e){
                Debug.Log(e.Message);
            }
        }
    }
}
