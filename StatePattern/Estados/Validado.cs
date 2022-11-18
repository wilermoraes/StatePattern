using StatePattern.Modelos;

namespace StatePattern.Estados
{
    public class Validado : IEstado
    {
        public Documento ProximoStatus(Documento documento)
        {
            documento.SetStatusEmImplantacao();
            return documento;
        }

        public Documento StatusAnterior(Documento documento)
        {
            documento.SetStatusEmValidacao();
            return documento;
        }

        public string ObterNomeEstado()
        {
            return "Validado";
        }
    }
}
