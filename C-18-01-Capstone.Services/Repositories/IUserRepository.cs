﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C_18_01_Capstone.Main.DataContext;

namespace C_18_01_Capstone.Services.Repositories
{
  public interface IUserRepository
  {
    void AddUser(User user);
  }
}
