using MediatR;
using System;

namespace SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra
{
    public class RegistrarCompraCommand : IRequest<bool>
    {
        public string Usuario { get; set; }
        public string Fornecedor { get; set; }
    }
}
