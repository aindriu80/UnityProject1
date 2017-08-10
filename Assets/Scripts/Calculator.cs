using UnityEngine;
using UnityEngine.UI;

public class Calculator : MonoBehaviour
{
    public InputField inputField1;
    public InputField inputField2;
    public Text resultText;



    // Use this for initialization
    void Start()
    {
        resultText.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Add()
    {
        float number1 = float.Parse(inputField1.text);
        float number2 = float.Parse(inputField2.text);
        resultText.text = (number1 + number2).ToString();
    }

    public void Subtract()
    {
        float number1 = float.Parse(inputField1.text);
        float number2 = float.Parse(inputField2.text);
        resultText.text = (number1 - number2).ToString();
    }
    public void Multiply()
    {
        float number1 = float.Parse(inputField1.text);
        float number2 = float.Parse(inputField2.text);
        resultText.text = (number1 * number2).ToString();
    }
    public void Divide()
    {
        float number1 = float.Parse(inputField1.text);
        float number2 = float.Parse(inputField2.text);
        resultText.text = (number1 / number2).ToString("#.00");
    }


}
