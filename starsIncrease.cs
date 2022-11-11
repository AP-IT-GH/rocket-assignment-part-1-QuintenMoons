using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starsIncrease : MonoBehaviour
{
    public float stars = 0f;
    
    public void ApplyStar(float amount)
    {
        stars = stars + amount;
    }
}
