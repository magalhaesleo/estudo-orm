using EstudoORM.Domain.Base;
using EstudoORM.Domain.Funcionalidades.Resultados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoORM.Domain.Funcionalidades.Alunos
{
    public class Aluno : Entidade
    {
        private double _media = 0;

        public string Nome { get; set; }
        public int Idade { get; set; }
        public virtual List<Resultado> Resultados { get; set; }
        public double Media
        {
            get
            {
                return _media;
            }
            set
            {
                _media = value;
            }
        }


        public double Calcular_media()
        {
            _media = 0;

            foreach (Resultado resultado in Resultados)
            {
                _media += resultado.Nota;
            }
            _media = _media / Resultados.Count;

            _media = Arredondar_media(_media);

            return _media;
        }

        public double Arredondar_media(double media)
        {
            double valorInteiro = Math.Truncate(media);
            double valorDecimal = media - valorInteiro;

            if (valorDecimal < 0.35)
            {
                valorDecimal = 0;
            }
            else if (valorDecimal >= 0.75)
            {
                valorDecimal = 1;
            }
            else
            {
                valorDecimal = 0.5;
            }

            double _mediaArredondada = valorInteiro + valorDecimal;

            return _mediaArredondada;
        }
    }
}
