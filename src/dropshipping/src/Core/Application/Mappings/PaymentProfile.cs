using AutoMapper;
using DropshippingAdmin.Core.Application.Dtos;
using DropshippingAdmin.Core.Domain.Entities;

namespace DropshippingAdmin.Core.Application.Mappings
{
    public class PaymentProfile : Profile
    {
        public PaymentProfile()
        {
            CreateMap<Payment, PaymentDto>().ReverseMap();
            CreateMap<PaymentsStatus, PaymentsStatusDto>().ReverseMap();
            CreateMap<Transaction, TransactionDto>().ReverseMap();
        }
    }
}
