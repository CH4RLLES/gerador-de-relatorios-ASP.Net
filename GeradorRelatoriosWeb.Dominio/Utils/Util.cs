using Microsoft.AspNetCore.Mvc.Rendering;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;

namespace GeradorRelatoriosWeb.Dominio.Utils
{
    public class Util
    {
        public const string keyCPF = "jA542fY4NWAZBnm6LxGJ6g5nBQeQ2ZW4GSj7QRGxLYNGtKxCV5YunRjx";
        public const string keySenha = "2f2435397459266a236f2247657e6e4b7a2a2733343b6a6f72582f4a27";

        public static string Criptografar(string Message, string token, string tipo)
        {
            byte[] Results;
            byte[] TDESKey;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            if (tipo == "CPF")
                TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(keyCPF + token));
            else
                TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(keySenha + token));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToEncrypt = UTF8.GetBytes(Message);
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return Convert.ToBase64String(Results);
        }

        public static string Descriptografar(string Message, string token, string tipo)
        {
            byte[] Results;
            byte[] TDESKey;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            if (tipo == "CPF")
                TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(keyCPF + token));
            else
                TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(keySenha + token));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToDecrypt = Convert.FromBase64String(Message);
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return UTF8.GetString(Results);
        }

        public static string GerarHash(string value)
        {
            UnicodeEncoding encoding = new UnicodeEncoding();
            byte[] hashBytes;
            using (HashAlgorithm hash = SHA1.Create())
                hashBytes = hash.ComputeHash(encoding.GetBytes(value));

            StringBuilder hashValue = new StringBuilder(hashBytes.Length * 2);
            foreach (byte b in hashBytes)
            {
                hashValue.AppendFormat(CultureInfo.InvariantCulture, "{0:X2}", b);
            }

            return hashValue.ToString();
        }

        public static string GerarSenhaNova()
        {
            int TamanhoDaSenha = 8;
            string caracteresPermitidos = "abcdefghijkmnopqrstuvwxyzABCDEFGHJKLMNOPQRSTUVWXYZ0123456789!@$?_-";
            char[] chars = new char[TamanhoDaSenha];
            Random rd = new Random();

            for (int i = 0; i < TamanhoDaSenha; i++)
            {
                chars[i] = caracteresPermitidos[rd.Next(0, caracteresPermitidos.Length)];
            }

            return new string(chars);
        }

        public static bool ValidarCNPJ(string cnpj)
        {
            int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int soma;
            int resto;
            string digito;
            string tempCnpj;
            cnpj = cnpj.Trim();
            cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "");
            if (cnpj.Length != 14)
                return false;
            tempCnpj = cnpj.Substring(0, 12);
            soma = 0;
            for (int i = 0; i < 12; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCnpj = tempCnpj + digito;
            soma = 0;
            for (int i = 0; i < 13; i++)
                soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
            resto = (soma % 11);
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cnpj.EndsWith(digito);
        }

        public static bool ValidarCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        public static string FormatCPFCNPJ(string CPFCNPJ)
        {
            if (CPFCNPJ.Length == 11)
                return Convert.ToUInt64(CPFCNPJ).ToString(@"000\.000\.000\-00");
            else
                return Convert.ToUInt64(CPFCNPJ).ToString(@"00\.000\.000\/0000\-00");
        }

        public static string FormatTelefone(string tel)
        {
            if (string.IsNullOrEmpty(tel))
                return tel;

            tel = tel.Replace("+55", "");
            if (tel.Length == 10)
                return Convert.ToInt64(tel).ToString("(00) 0000-0000");
            else
                return Convert.ToInt64(tel).ToString("(00) 00000-0000");
        }

        public static IDictionary<int, string> GetEnumToDropDown<TEnum>() where TEnum : struct
        {
            var enumerationType = typeof(TEnum);

            if (!enumerationType.IsEnum)
                throw new ArgumentException("Enumeration type is expected.");

            var dictionary = new Dictionary<int, string>();

            foreach (int value in Enum.GetValues(enumerationType))
            {
                var memInfo = enumerationType.GetMember(enumerationType.GetEnumName(value));
                var descriptionAttribute = memInfo[0]
                    .GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .FirstOrDefault() as DescriptionAttribute;

                var name = descriptionAttribute.Description;
                dictionary.Add(value, name.ToString());
            }
            return dictionary;
        }

        public static SelectList GetEnumToSelectList<TEnum>() where TEnum : struct
        {
            var enumerationType = typeof(TEnum);

            if (!enumerationType.IsEnum)
                throw new ArgumentException("Enumeration type is expected.");

            var dictionary = new Dictionary<int, string>();

            foreach (int value in Enum.GetValues(enumerationType))
            {
                var memInfo = enumerationType.GetMember(enumerationType.GetEnumName(value));
                var descriptionAttribute = memInfo[0]
                    .GetCustomAttributes(typeof(DescriptionAttribute), false)
                    .FirstOrDefault() as DescriptionAttribute;

                var name = descriptionAttribute.Description;
                dictionary.Add(value, name.ToString());
            }

            var ret = new SelectList(dictionary.ToList(), "Key", "Value");
            return ret;
        }

        public static ExcelWorksheet MontaCabecalho(Type classe, ExcelWorksheet planilha)
        {
            PropertyInfo[] propInfos = classe.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var col = 1;

            foreach (var propInfo in propInfos)
            {
                MemberInfo property = classe.GetProperty(propInfo.Name);
                var dd = property.GetCustomAttribute(typeof(DisplayAttribute)) as DisplayAttribute;
                if (dd != null && !string.IsNullOrEmpty(dd.Name))
                {
                    planilha.Cells[1, col].Value = dd.Name;
                }
                else
                {
                    planilha.Cells[1, col].Value = propInfo.Name;
                }
                planilha.Cells[1, col].Style.Fill.PatternType = ExcelFillStyle.Solid;
                planilha.Cells[1, col].Style.Fill.BackgroundColor.SetColor(System.Drawing.Color.CadetBlue);
                planilha.Cells[1, col].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                planilha.Cells[1, col].Style.Font.Bold = true;
                col++;
            }

            return planilha;
        }

        public static List<string> BuscaUsuariosSRs()
        {
            return new List<string>
            {
                "Mateus Filipe de Souza",
                "Davi Salomão Elias",
                "Hugo José da Silva",
                "Alexandre Bezerra Mariano",
                "Shyrlene Hosana de Sousa Araújo",
                "Hélen Juliane Tenório Silva de Araújo",
                "Kátia Rodrigues Pinto",
                "Lucca Ildefonso Pires Tavares Alves",
                "Luciano José de Souza e Silva",
                "Alessandra Emanuelle Santos Silva",
                "Marcia Souza Brazão",
                "Marcos Antonio Prates Rosa",
                "Fabia Fernanda de Oliveira Tavares",
                "Jean Petter Mendes Pereira",
                "Arthur Araújo de Brito",
                "Pollyana Kelly Teodozio Meireles",
                "Davi Braga da Rocha",
                "Joel da Silva Alencar",
                "Allane Dáffenin da Rocha E Silva",
                "Lucinalva Pereira da Silva",
                "Carolina Carvalho Pimentel",
                "Millena Lima de Souza",
                "Luciene Carlos da Silva Pereira",
                "Steffanny Nascimento de Maria",
                "Carlos Marcony da Silva e Silva",
                "Renato Lopes da Silva",
                "Letícia Maria Araújo Magalhães",
                "Iracy Quaresma Costa",
                "Jhonatan Henrique Pereira da Silva",
                "Claudete Freitas de Miranda",
                "Rafael de Lima Medeiros",
                "Bruna Leges de Andrade",
                "Laina Vargas Moraes",
                "Lucimar Alves Stephan",
                "Lívia de Moura David",
                "Bruno Ribeiro de Carvalho",
                "Lucas Oliveira Silva",
                "Alícia Lanza de Bitencourt",
                "Wilson Fiedler Gugick",
                "Alice Mayara Silva e Souza",
                "Rayssa Gabrielly dos Santos Rocha",
                "Paula Falco Yokowo",
                "Raphael Couto Andrade",
                "Natalha Gomes Da Silva",
                "Luana Benedita Gomes da Silva",
                "jeane teles da silva",
                "Maria das Dores Marques da Silva",
                "Fabio Calhordo Dallava",
                "Fernanda Gabler",
                "Luciana Damascena Gonçalves",
                "Mayara Marcia Bessa Vieira",
                "Gustavo Rodrigues de Oliveira",
                "Camila Danielle de Paula Santos",
                "Itamir da Cruz Sampaio",
                "Vitor Fabian Oliveira",
                "Thabata Pontes Barros",
                "Sara Soeiro Vieira de Lira",
                "Deborah Cristina de Sousa Brito",
                "Luciana Mendes Alcântara",
                "Graziela da Silva Fernandes",
                "Bianca do Nascimento Lima",
                "Jefferson Galvão Santos",
                "Julia Medeiros Machado Mattos",
                "Felipe Douglas Barbosa de Oliveira",
                "Leonilson Stefano Moura Sá",
                "Rafael da Silva Reis",
                "Valdir Lixa Moreira",
                "Amanda Sena da Silva",
                "Izabel Cristina de Brito Siqueira Campos",
                "Natalia Ferreira de Sousa",
                "Rafaela Sousa Dias",
                "Soraya da Conceição Malaquias",
                "Débora Santos Gonçalves",
                "Vanessa Souza do Nascimento",
                "Silvia Cristina Santos da Costa"
            };
        }
    }
}
