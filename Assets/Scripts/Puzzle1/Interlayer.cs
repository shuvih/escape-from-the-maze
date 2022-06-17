using System.Collections.Generic;
using UnityEngine;

public class Interlayer : MonoBehaviour
{
    [SerializeField] private int maxTotems;
    [SerializeField] private Obstacle obstacle;
    private List<Totem> totems = new List<Totem>();

    public void click(Totem totem)
    {
        totems.Add(totem);
        if (totems.Count == maxTotems)
        {
            bool isCorrect = true;
            for (int i = 0; i < maxTotems-1; i++)
            {
                isCorrect = isCorrect && totems[i].getNumber() < totems[i+1].getNumber();
            }
            if (isCorrect)
            {
                obstacle.open();
            }
            else
            {
                for (int i = 0; i < maxTotems; i++)
                {
                    totems[i].extinguishTotem();
                }
                totems = new List<Totem>();
            }
        }
    }
}
