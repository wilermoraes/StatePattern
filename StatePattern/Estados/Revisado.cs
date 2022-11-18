using StatePattern.Modelos;

namespace StatePattern.Estados
{
    public class Revisado : IEstado
    {
        public Documento ProximoStatus(Documento documento)
        {
            documento.SetStatusEmValidacao();
            return documento;
        }

        public Documento StatusAnterior(Documento documento)
        {
            documento.SetStatusEmRevisao();
            return documento;
        }

        public string ObterNomeEstado()
        {
            return "Revisado";
        }
    }
}
