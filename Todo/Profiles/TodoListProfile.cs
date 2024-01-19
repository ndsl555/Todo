using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Todo.Dtos;
using Todo.Models;

namespace Todo.Profiles
{
    public class TodoListProfile: Profile
    {
        public TodoListProfile()
        {
            CreateMap<TodoList, TodoListSelectDto>()
                .ForMember(
                dest=>dest.InsertEmployeeName,
                opt=>opt.MapFrom(src=>src.InsertEmployee.Name+"("+src.InsertEmployeeId+")")                
                )
                .ForMember(
                dest => dest.UpdateEmployeeName,
                opt => opt.MapFrom(src => src.UpdateEmployee.Name + "(" + src.UpdateEmployeeId + ")")
                );
            CreateMap<TodoListPostDto, TodoList>();
            CreateMap<TodoListPutDto, TodoList>()
                .ForMember(
                dest => dest.UpdateTime,
                opt => opt.MapFrom(src => DateTime.Now)
                )
                .ForMember(
                dest => dest.InsertEmployeeId,
                opt => opt.MapFrom(src => Guid.Parse("00000000-0000-0000-0000-000000000001"))
                );
        }
    }
}
