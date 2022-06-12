using UnityEngine;

public class Button_Cont : MonoBehaviour
{
    public string NameLevel;
    public void Update()
    {
        if(Input.GetKeyUp(KeyCode.Escape)|Input.GetKayCode.Space))
                {
            Application.LoadLevel(NameLevel);
        }
    }
}
