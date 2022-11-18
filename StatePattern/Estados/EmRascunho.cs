using StatePattern.Modelos;
using System;

namespace StatePattern.Estados
{
    public class EmRascunho : IEstado
    {
        public Documento ProximoStatus(Documento documento)
        {
            documento.SetStatusParaRevisao();
            return documento;
        }

        public Documento StatusAnterior(Documento documento)
        {
            Console.WriteLine($"O estado atual não possui nenhum estado anterior.");
            return documento;
        }

        public string ObterNomeEstado()
        {
            return "Em Rascunho";
        }
    }
}
