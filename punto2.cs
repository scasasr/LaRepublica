// See https://aka.ms/new-console-template for more information
using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;

public class punto2 { 

    static void Main(string[] args) {

        Console.WriteLine("Ingrese un número, por favor: ");

        string numero =Console.ReadLine();//ingreso de numero por parte del usuario 

        static bool isCapicua(string s) {//funcion que determina si el numero ingresado es capicua
            int len = s.Length;
            int mitad = len / 2;

            string primeraMitad = "";
            string segundaMitad = "";
            string reverso = "";

            if (s.Length % 2 == 1)
            {
                primeraMitad = s.Substring(0, mitad);
                segundaMitad = s.Substring(mitad+1);
                for (int i = segundaMitad.Length - 1; i >= 0; i--)
                {
                    reverso += segundaMitad[i];
                }

            }
            else {
                primeraMitad = s.Substring(0, mitad);
                segundaMitad = s.Substring(mitad);
                for (int i = segundaMitad.Length - 1; i >= 0; i--)
                {
                    reverso += segundaMitad[i];
                }
                   
            }
            return primeraMitad==reverso;
        }

        static string getNumeroDescendiente(string s) {//función que devuelve el descendiente de un numero
            int i = 0;
            string descendiente = "";
            if (s.Length == 2) {
                return "12";
            }
            while(i < s.Length -1 )
            {
                descendiente += (CharUnicodeInfo.GetDecimalDigitValue(s[i]) + CharUnicodeInfo.GetDecimalDigitValue(s[i + 1])).ToString();
                i = i + 2;
            }
            return descendiente;
        }


        static bool descendienteCapicua(string s) {//funcion solucion
            if (isCapicua(s)) //caso base
            {
                return true;
            }
            else {
                if (s.Length % 2 == 1 || s == "12")
                {
                    return false;
                }
                else {
                    return descendienteCapicua(getNumeroDescendiente(s));
                }
            }
        
        }


        Console.WriteLine(descendienteCapicua(numero));
        



    
    }



}
