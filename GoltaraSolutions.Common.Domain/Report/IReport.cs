using GoltaraSolutions.Common.Domain;
using System.Collections.Generic;

namespace GoltaraSolutions.Common.Domain.Report
{
    public interface IReport<T> where T : Aggregate
    {
        T Find(long idEmpresa, string nome);
        
        ICollection<T> List(long idEmpresa);

        List<FiltrosReportView> ListarFiltros(long idEmpresa, bool? deletado);
    }
}
