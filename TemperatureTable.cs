Celcius();
TempTable();


void Celcius()
{
System.Console.WriteLine("Please enter in your temperature in Fahrenheit.");
double Fahrenheit = Double.Parse(Console.ReadLine());
double conversion = (Fahrenheit - 32) * 5/9;
System.Console.WriteLine($"The temperature in celcius is {Math.Round(conversion, 2)} degrees");

 
    //const int MinTemp = 80;
    // const int MaxTemp = 101; 
     //for(int i = MinTemp; i < MaxTemp; i++)
    // {
     //  int  f = ( i - 32) * 5 / 9 ;
     //   Console.WriteLine("\t" + i + "\t\t" + f);
    // }
     
 }   


 void TempTable()
 {  

     const int MinTemp = 80;
     const int MaxTemp = 101; 
     for(int i = MinTemp; i < MaxTemp; i++)
     {
       int  f = ( i - 32) * 5 / 9 ;
        Console.WriteLine("\t" + i + "\t\t" + f);
     }
 }


  


