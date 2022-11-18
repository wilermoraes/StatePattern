using StatePattern.Modelos;

namespace StatePattern.Estados
{
    public class EmRevisao : IEstado
    {
        public Documento ProximoStatus(Documento documento)
        {
            documento.SetStatusRevisado();
            return documento;
        }

        public Documento StatusAnterior(Documento documento)
        {
            documento.SetStatusParaRevisao();
            return documento;
        }

        public string ObterNomeEstado()
        {
            return "Em Revisão";
        }
    }
}
