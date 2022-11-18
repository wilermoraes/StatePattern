using StatePattern.Modelos;
using System;

namespace StatePattern.Estados
{
    public class Implantado : IEstado
    {
        public Documento ProximoStatus(Documento documento)
        {
            Console.WriteLine($"O estado atual não possui nenhum estado posterior.");
            return documento;
        }

        public Documento StatusAnterior(Documento documento)
        {
            documento.SetStatusEmImplantacao();
            return documento;
        }

        public string ObterNomeEstado()
        {
            return "Implantado";
        }
    }
}
