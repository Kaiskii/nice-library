using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum TimeType {
  REAL_TIME,
  TURN_BASE,
}

[System.Serializable]
public class CharacterName{
  
  [SerializeField]
  public string name;
}

[System.Serializable]
public class StatDataTypeName{
  
  [SerializeField]
  public string name;
}

[System.Serializable]
public class EffectName{
  
  [SerializeField]
  public string name;
}

/*
[System.Serializable]
class EffectTypes{
  
  [SerializeField]
  TimeType mode;

  [SerializeField]
  string name;

  [SerializeField]
  int totalEffectDuration;

   [SerializeField]
  int totalEffectTurn;

  [SerializeField]
  int tickPerDuration;

  [SerializeField]
  int tickPerTurn;
}
*/
[System.Serializable]
[CreateAssetMenu(fileName = "DataInputScript", menuName = "ScriptableObjects/Effect Data Scriptable", order = 2)]
public class DataInputScript : ScriptableObject {
  [SerializeField]
  public TimeType mode;

  [SerializeField]
  public List<CharacterName> characters;
  
  [SerializeField]
  public List<StatDataTypeName> statNames;

  [SerializeField] 
  public List<EffectName> effects;

/*
  [SerializeField]
  List<EffectTypes> effects;
*/
}