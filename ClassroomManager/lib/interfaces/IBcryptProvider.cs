﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomManager.lib.interfaces
{
  internal interface IBcryptProvider
  {
    string HashPassword(string password);
    bool VerifyPassword(string password, string hash);
  }
}
