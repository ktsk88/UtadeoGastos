
using System.IO;

using AutoMapper;

using UtadeoGastos.Data;
using UtadeoGastos.Dtos;

namespace UtadeoGastos.LogicBusiness
{
    public class AutoMapperProfile : Profile
    {

        public AutoMapperProfile()
        {
            CreateMap<GastosContract, Gastos>();
            CreateMap<Gastos, ReadGastosContract>().ReverseMap();
        }
    }
}
