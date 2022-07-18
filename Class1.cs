using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Tratar_erros
{
    //classe para validar a string com os métodos
    public static class Validador
    {
        //metodo apra retornar booleano,metodo para verificar se uma string é uma data válida no formato DateTime
        public static bool VerificarData(string data)
        {
            try
            {
                //DateTime é um tipo
                DateTime dataConvertida = Convert.ToDateTime(data);
                return true;
            }
            catch
            {

                Console.WriteLine("valor não pode ser convertido");
                return false;
            }
        }
        //Booleano para verificar se um valor string pode ser convertido em inteiro
        public static bool verificarInteiro(string inteiro)
        {
            try
            {
                int inteiroConvertido = Int32.Parse(inteiro);
                return true;
            }
            catch
            {
                Console.WriteLine("Valor não pode ser convertido");
                return false;
            }
        }

            //booleano para verificar se um valor string pode ser convertido em um email válido
            public static bool verificarEmail(string email)
            {
                
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);//verifica se o email é válido


            if (match.Success == true)
                return true;
            else
                return false;
            }
               
            //booleano para verificar se um valor string pode se converter em decimal
             public static bool verificarDecimal(string decim)
        {
            try
            {
                decimal convertdecimal = Convert.ToDecimal(decim);
                return true;
            }
            catch 
            {
                Console.WriteLine("Valor não pode ser convertido");
                return false;  
            }
        }

        }
    }

