namespace GoltaraSolutions.Common
{
    public struct DiasSemana
    {
        public bool Segunda { get; set; }
        public bool Terca { get; set; }
        public bool Quarta { get; set; }
        public bool Quinta { get; set; }
        public bool Sexta { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public void ValidarPeloMenosUmMarcado()
        {
            if (!Segunda && !Terca && !Quarta && !Quinta && !Sexta && !Sabado && !Domingo)
                throw new Exceptions.DiasSemanaInvalidoException("Nenhum dia da semana foi selecionado.");
        }
    }
}
