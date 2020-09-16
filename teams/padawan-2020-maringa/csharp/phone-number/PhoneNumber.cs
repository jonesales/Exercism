using System;
using System.Text.RegularExpressions;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        var numero = Regex.Replace(phoneNumber, "[^0-9]", "");

        if (numero.Length > 11 || numero.Length < 10)
            throw new ArgumentException();

        if (numero.Length == 11)

            if (Regex.IsMatch(numero, "^[1]"))
                numero = numero.Remove(0, 1);
            else
                throw new ArgumentException();

        if (Regex.IsMatch(numero, "^[0-1]") || Regex.IsMatch(numero, "^...[0-1]"))
            throw new ArgumentException();

       // if (numero[3] == '0' || numero[3] == '1')
         //   throw new ArgumentException();

        return numero;
    }
}