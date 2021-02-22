using System;

namespace GoltaraSolutions.Common
{
    public struct Horario
    {
        public Horario(int hora, int minuto)
        {
            Hora = hora;
            Minuto = minuto;
            Validar();
        }
        public int Hora { get; private set; }
        public int Minuto { get; private set; }
        private void Validar()
        {
            if (Hora < 0 || Hora >= 24)
                throw new Exceptions.HorarioInvalidoException(String.Format("Hora(s) {0} inválida(s).", Hora));
            if (Minuto < 0 || Minuto >= 60)
                throw new Exceptions.HorarioInvalidoException(String.Format("Minuto(s) {0} inválida(s).", Minuto));
        }
    }
}
