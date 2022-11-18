using StatePattern.Modelos;

namespace StatePattern.Estados
{
    public class ParaRevisao : IEstado
    {
        public Documento ProximoStatus(Documento documento)
        {
            documento.SetStatusEmRevisao();
            return documento;
        }

        public Documento StatusAnterior(Documento documento)
        {
            documento.SetStatusEmRascunho();
            return documento;
        }

        public string ObterNomeEstado()
        {
            return "Para Revisão";
        }
    }
}
