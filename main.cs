using System;
using System.Linq;

class MainClass {

    static void PrintArray(int[] arr)  
    {  
        foreach (int elem in arr)  
        {  
            Console.Write(elem+" ");  
        }  
    }

  public static void Main (string[] args) {
    int i = 0;
    int[] numArray = new int[10];

    do{
      Console.WriteLine("Digite um numero da posicao " + i + ":  ");
      int num = Int16.Parse(Console.ReadLine());

      if (i == 0)
      {
          numArray[i] = num;
          i++;
      }
      else
      {
          bool tem = false;
          int j = 0;
          for (j = 0; j < 10; j++)
          {
              if (num == numArray[j])
              {
                  tem = true;
                  break;
              }
          }
          if (tem == false)
          {
              numArray[i] = num;
              i++;
          }
      }
      //Console.WriteLine(numArray[i]);
    }while (i < 10);

    PrintArray(numArray);
    //Console.ReadKey();

    int max = numArray.Max();

    Console.WriteLine("\n"+"Maior: " + max);

    int secMax;
    if (numArray[0] != max)
      secMax = numArray[0];
    else
      secMax = numArray[1];

      foreach(int elem in numArray){
        if (elem != max && secMax < elem)
        {
          secMax = elem;
        }
      }
      Console.WriteLine("\n"+"Segundo Maior:"+ secMax);
  }
    
} 