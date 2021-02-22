using System;

namespace GoltaraSolutions.Common
{
    public struct Periodo
    {
        public Periodo(DateTime dataInicial, DateTime dataFinal)
        {
            MenorDataValida = new DateTime(1900, 01, 01);
            MaiorDataValida = new DateTime(2100, 01, 01);
            DataInicial = dataInicial;
            DataFinal = dataFinal;

            Validar();
        }
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }
              public DateTime MenorDataValida { get; }
        public DateTime MaiorDataValida { get; }
        private void Validar()
        {
            if (DataInicial < MenorDataValida)
                throw new Exceptions.PeriodoInvalidoException(String.Format("Data inicial {0} deve ser maior que {1}.", DataInicial, MenorDataValida));

            if (DataFinal > MaiorDataValida)
                throw new Exceptions.PeriodoInvalidoException(String.Format("Data final {0} deve ser menor que {1}.", DataFinal, MaiorDataValida));

            if (DataInicial > DataFinal)
                throw new Exceptions.PeriodoInvalidoException(String.Format("Data inicial {0} maior que a data final {1}.", DataInicial, DataFinal));
        }
    }
}
