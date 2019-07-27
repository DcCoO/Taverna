using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {
    public int id;
    /// <summary>aumenta o dinheiro das missoes</summary>
    [Range(0, 1)] public float missionRewardBonus;  
    /// <summary>aumenta dinheiro dos clientes</summary>   
    [Range(0, 1)] public float clientRewardBonus;   
    /// <summary>reducao de tempo de chegada dos herois</summary>  
    [Range(0, 1)] public float heroArrivalRate;
    /// <summary>reducao de tempo de chegada de missao</summary>  
    [Range(0, 1)] public float missionArrivalRate;     
    /// <summary>reducao de tempo para realizar missoes</summary>  
    [Range(0, 1)] public float missionCompletionRate;
    /// <summary>reducao de tempo de chegada das classes</summary>  
    public float[] classArrivalRate;
    /// <summary>reducao de tempo entre os boatos</summary>  
    public float[] rumorTime;

}

