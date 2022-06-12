using UnityEngine;

public class FastContLvl : MonoBehaviour
{
    public bool NextLevel;
    public string NameLevel;
    // Update is called once per frame
    void Update()
        if(NextLevel==true)
    {
        Application.LoadLevel(NameLevel)
    }
}
