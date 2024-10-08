﻿using Numero3.EntityFramework.Demo.DomainModel;
using System;
using System.Threading.Tasks;

namespace Numero3.EntityFramework.Demo.Repositories {
    public interface IUserRepository {
        User Get(Guid userId);
        ValueTask<User> GetAsync(Guid userId);
        void Add(User user);
    }
}