using API.DTOs.Users;
using Domain.Interfaces;
using Domain.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services.Users
{
    public class UserService : BaseService
    {
        public UserService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<AddUserResponse> AddNewAsync(AddUserRequest model)
        {
        
            var user = new User(model.UserName
                , model.Password
                , model.Address
                , model.DepartmentId.Value);

            var repository = UnitOfWork.AsyncRepository<User>();
            await repository.AddAsync(user);
            await UnitOfWork.SaveChangesAsync();

            var response = new AddUserResponse()
            {
                Id = user.Id,
                UserName = user.UserName
            };

            return response;
        }

       

        public async Task<List<UserInfoDTO>> SearchAsync(GetUserRequest request)
        {
            var repository = UnitOfWork.AsyncRepository<User>();
            var users = await repository
                .ListAsync(_ => _.UserName.Contains(request.Search));

            var userDTOs = users.Select(_ => new UserInfoDTO()
            {
                Address = _.Address,
                DepartmentId = _.DepartmentId,
                Password = _.Password,
                Id = _.Id,
                UserName = _.UserName
            })
            .ToList();

            return userDTOs;
        }
    }
}