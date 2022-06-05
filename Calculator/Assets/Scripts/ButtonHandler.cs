using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    public string value;
    public PanelHandler panel;

    void Start()
    {
        panel = GameObject.Find("Panel").GetComponent<PanelHandler>();
    }

    public void AddValue()
    {
        panel.AddValue(value);
    }

    public void Calculate()
    {
        panel.WriteAnswer();
    }

    public void Clear()
    {
        panel.Clear();
    }
}
