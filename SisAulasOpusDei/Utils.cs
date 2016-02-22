using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisAulasOpusDei
{
    public static class Utils
    {

        public static string ToRoman(int number)
        {
            if ((number < 0) || (number > 3999)) throw new ArgumentOutOfRangeException("insert value betwheen 1 and 3999");
            if (number < 1) return string.Empty;
            if (number >= 1000) return "M" + ToRoman(number - 1000);
            if (number >= 900) return "CM" + ToRoman(number - 900); //EDIT: i've typed 400 instead 900
            if (number >= 500) return "D" + ToRoman(number - 500);
            if (number >= 400) return "CD" + ToRoman(number - 400);
            if (number >= 100) return "C" + ToRoman(number - 100);
            if (number >= 90) return "XC" + ToRoman(number - 90);
            if (number >= 50) return "L" + ToRoman(number - 50);
            if (number >= 40) return "XL" + ToRoman(number - 40);
            if (number >= 10) return "X" + ToRoman(number - 10);
            if (number >= 9) return "IX" + ToRoman(number - 9);
            if (number >= 5) return "V" + ToRoman(number - 5);
            if (number >= 4) return "IV" + ToRoman(number - 4);
            if (number >= 1) return "I" + ToRoman(number - 1);
            throw new ArgumentOutOfRangeException("something bad happened");
        }

        public static string TipoMateriaToLatin(int idTipoMateria)
        {
            switch (idTipoMateria)
            {
                case 1://Teologia
                    return "S. THEOLOGIA";
                case 2://Filosofia
                    return "PHILOSOPHIAE";
                default:
                    return "";
            }
        }

        public static string TipoMateriaToLatin(string tipoMateria)
        {
            switch (tipoMateria)
            {
                case "Teologia":
                    return "S. THEOLOGIA";
                case "Filosofia":
                    return "PHILOSOPHIAE";
                default:
                    return "";
            }
        }

        public static class Curriculo
        {
            public const int linhasRodape = 11;
            public const int linhasRodapePagina = 7;
            public const int qtdMateriasPrimeiraPg = 31;
            public const int qtdMateriasPagina = 49;
        }


        public static class Ata
        {
            public const int linhasRodape = 11;
            public const int linhasRodapePagina = 7;
            public const int qtdAlunosPrimeiraPg = 31;
            public const int qtdAlunosPagina = 49;
        }
        
        public sealed class Meses
        {

            private readonly Dictionary<string,string> name;
            private readonly int value;
            public const string PORTUGUES = "pt_br";
            public const string LATIM = "latin";

            private static readonly Dictionary<int, Meses> instance = new Dictionary<int, Meses>()
            {
               {1,new Meses(1, new Dictionary<string, string>() { { PORTUGUES, "janeiro" }, { LATIM, "januario" } })},
               {2,new Meses(2, new Dictionary<string, string>() { { PORTUGUES, "fevereiro" }, { LATIM, "februario" } })},
               {3,new Meses(3, new Dictionary<string, string>() { { PORTUGUES, "março" }, { LATIM, "martio" } })},
               {4,new Meses(4, new Dictionary<string, string>() { { PORTUGUES, "abril" }, { LATIM, "aprili" } })},
               {5,new Meses(5, new Dictionary<string, string>() { { PORTUGUES, "maio" }, { LATIM, "maio" } })},
               {6,new Meses(6, new Dictionary<string, string>() { { PORTUGUES, "junho" }, { LATIM, "iunio" } })},
               {7,new Meses(7, new Dictionary<string, string>() { { PORTUGUES, "julho" }, { LATIM, "iulio" } })},
               {8,new Meses(8, new Dictionary<string, string>() { { PORTUGUES, "agosto" }, { LATIM, "augusto" } })},
               {9,new Meses(9, new Dictionary<string, string>() { { PORTUGUES, "setembro" }, { LATIM, "septembri" } })},
               {10,new Meses(10, new Dictionary<string, string>() { { PORTUGUES, "outubro" }, { LATIM, "octobri" } })},
               {11,new Meses(11, new Dictionary<string, string>() { { PORTUGUES, "novembro" }, { LATIM, "novembri" } })},
               {12,new Meses(12, new Dictionary<string, string>() { { PORTUGUES, "dezembro" }, { LATIM, "decembri" } })}

            };

               

            private Meses(int value, Dictionary<string, string> name)
            {
                this.name = name;
                this.value = value;
            }

            public String ToString(string language)
            {
                return name[language];
            }
            public override String ToString()
            {
                return name[PORTUGUES];
            }
            public static Meses get(int value)
            {
                if(instance.ContainsKey(value)){
                    return instance[value];
                }
                return null;
            }
        }
    }
}
