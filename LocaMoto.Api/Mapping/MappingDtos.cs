using LocaMoto.Api.Entities;
using System.Runtime.CompilerServices;
using LocaMoto.Models.DTOs;


namespace LocaMoto.Api.Mapping;

public static class MappingDtos
{
    public static IEnumerable<CategoriaDto> ConverterCategoriasParaDto(
                                            this IEnumerable<Categoria> categorias)
    {
        return (from categoria in categorias
                select new CategoriaDto
                {
                    Id = categoria.Id,
                    Tipo = categoria.Tipo,
                    Descricao = categoria.Descricao
                }).ToList();
    }
}
