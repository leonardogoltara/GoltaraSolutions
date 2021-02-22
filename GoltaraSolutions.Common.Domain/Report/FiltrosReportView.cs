namespace GoltaraSolutions.Common.Domain.Report
{
    public class FiltrosReportView
    {
        public FiltrosReportView(long id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public long Id { get; private set; }
        public string Nome { get; set; }
    }
}
