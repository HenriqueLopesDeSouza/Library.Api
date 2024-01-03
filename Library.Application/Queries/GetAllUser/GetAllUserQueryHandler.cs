using Library.Application.Queries.GetUser;
using Library.Application.ViewModels;
using Library.Core.DTOs;
using Library.Core.Entities;
using Library.Core.Repositories;
using MediatR;

namespace Library.Application.Queries.GetAllUser
{
    public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQuery, List<UserDTO>>
    {
        private readonly IUserRepository _userRepository;
        public GetAllUserQueryHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserDTO>> Handle(GetAllUserQuery request, CancellationToken cancellationToken)
        {
            var userList = await _userRepository.GetAllAsync();
            var userDTOList = MapUserListToUserDTOList(userList);
            return userDTOList;
        }

        private List<UserDTO> MapUserListToUserDTOList(IEnumerable<User> userList)
        {
            var userDTOList = new List<UserDTO>();

            foreach (var user in userList)
            {
                var userDTO = new UserDTO
                (
                   user.FullName,
                   user.Email
                );

                userDTOList.Add(userDTO);
            }

            return userDTOList;
        }

    }
}
