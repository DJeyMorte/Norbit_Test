using System.ComponentModel;

public class BMI {
    //Индекс массы тела
    public float Index {get;}
    //Интерпритация числовых показателей
    public string Interpritation {get;} = "Нормальный";
    public BMI(int mass,float height) {
        
        Index =  mass / (height * height);
          if(Index <= 18.5)
            Interpritation = "Ниже нормального";
          if(Index >= 25) 
            Interpritation = "Выше нормального";
    }
}