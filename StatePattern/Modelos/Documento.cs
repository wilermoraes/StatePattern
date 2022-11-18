using StatePattern.Estados;
using System;

namespace StatePattern.Modelos
{
    public class Documento
    {
        public Guid Id { get; private set; }
        public string? Descricao { get; private set; }
        public IEstado Estado { get; private set; }

        public Documento(string descricao)
        {
            Id = Guid.NewGuid();
            Descricao = descricao;
            Estado = new EmRascunho();
        }

        internal void SetStatusEmRascunho() => Estado = new EmRascunho();
        internal void SetStatusParaRevisao() => Estado = new ParaRevisao();
        internal void SetStatusEmRevisao() => Estado = new EmRevisao();
        internal void SetStatusRevisado() => Estado = new Revisado();
        internal void SetStatusEmValidacao() => Estado = new EmValidacao();
        internal void SetStatusValidado() => Estado = new Validado();
        internal void SetStatusEmImplantacao() => Estado = new EmImplantacao();
        internal void SetStatusImplantado() => Estado = new Implantado();

        public void ProximoStatus() => Estado.ProximoStatus(this);
        public void StatusAnterior() => Estado.StatusAnterior(this);
        public override string ToString() => Estado.ObterNomeEstado();
    }
}
