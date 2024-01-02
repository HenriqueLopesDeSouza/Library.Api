
﻿using Library.Application.ViewModels;
using Library.Core.DTOs;
using Library.Core.Entities;
using MediatR;


namespace Library.Application.Queries.GetUser
{
    public class GetAllUserQuery : IRequest<List<UserDTO>>
    {

    }
}
