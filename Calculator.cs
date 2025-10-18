namespace App.Core;

public class Calculator
{
    public int Sum(int a , int b) => a + b;
    public int Sub(int a , int b) => a - b;
    public int Mul(int a , int b) => a * b; 

    public int Div(int a , int b) 
    { 
        if (b == 0) 
            throw new DivideByZeroException("Denominador nao pode ser zero.");
        return a / b;
    }
   
    public bool IsPrime(int n) // [cite: 98]
    {
        if (n < 2) return false; // [cite: 100]
       
        for (int i = 2; i * i <= n; i++) // [cite: 101]
        {
            if (n % i == 0) return false; // Adaptação da lógica 
        }
        return true; // [cite: 103]
    }

}
