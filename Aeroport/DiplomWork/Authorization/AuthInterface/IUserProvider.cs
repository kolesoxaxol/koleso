﻿using AirModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomWork.Authorization.AuthInterface
{
    public interface IUserProvider
    {
        User User { get; set; }
    }
}
