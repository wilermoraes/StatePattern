using StatePattern.Modelos;

namespace StatePattern.Estados
{
    public class EmValidacao : IEstado
    {
        public Documento ProximoStatus(Documento documento)
        {
            documento.SetStatusValidado();
            return documento;
        }

        public Documento StatusAnterior(Documento documento)
        {
            documento.SetStatusRevisado();
            return documento;
        }

        public string ObterNomeEstado()
        {
            return "Em Validação";
        }
    }
}
