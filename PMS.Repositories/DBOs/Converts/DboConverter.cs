using AutoMapper;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PMS.Models.Entities;

namespace PMS.Repositories.DBOs.Converts;

public class DboConverter : IDboConverter
{
    private readonly IMapper mapper;

    public DboConverter()
    {
        mapper = CreateMapper();
    }

    public TResult Convert<TResult>(object source)
    {
        return mapper.Map<TResult>(source);
    }

    private static IMapper CreateMapper()
    {
        var configuration = new MapperConfiguration(cfg =>
        {
            cfg.ClearPrefixes();
            cfg.AllowNullCollections = false;

            cfg.CreateMap<Project, ProjectDbo>().ReverseMap();
            cfg.CreateMap<Assignment, AssignmentDbo>().ReverseMap();
            cfg.CreateMap<Person, PersonDbo>().ReverseMap();
            cfg.CreateMap<Comment, CommentDbo>().ReverseMap();
        });
        return configuration.CreateMapper();
    }
}
