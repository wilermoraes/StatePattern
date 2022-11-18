using StatePattern.Modelos;

namespace StatePattern.Estados
{
    public interface IEstado
    {
        Documento ProximoStatus(Documento documento);
        Documento StatusAnterior(Documento documento);
        string ObterNomeEstado();
    }
}
