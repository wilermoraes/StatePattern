using StatePattern.Modelos;

namespace StatePattern.Estados
{
    public class EmImplantacao : IEstado
    {
        public Documento ProximoStatus(Documento documento)
        {
            documento.SetStatusImplantado();
            return documento;
        }

        public Documento StatusAnterior(Documento documento)
        {
            documento.SetStatusValidado();
            return documento;
        }

        public string ObterNomeEstado()
        {
            return "Em Implantação";
        }
    }
}
