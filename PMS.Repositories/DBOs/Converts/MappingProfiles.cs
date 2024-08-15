using AutoMapper;
using PMS.Models.Entities;

namespace PMS.Repositories.DBOs.Convert;

/// <summary>
/// Profil mapowania modeli na modele DBO.
/// </summary>
public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Project, ProjectDbo>().ReverseMap();
        CreateMap<Assignment, AssignmentDbo>().ReverseMap();
        CreateMap<Person, Person>().ReverseMap();
        CreateMap<Comment, CommentDbo>().ReverseMap();
    }
}
