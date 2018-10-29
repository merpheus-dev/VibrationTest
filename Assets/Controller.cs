using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{

    public void Peek()
    {
        Vibration.VibratePeek();
    }


    public void Pop()
    {
        Vibration.VibratePop();
    }

    public void Nope()
    {
        Vibration.VibrateNope();
    }

    public void Standart()
    {
        Vibration.Vibrate();
    }

}
