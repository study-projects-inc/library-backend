﻿using Library.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Services
{
    public interface IAuthorService
    {
        List<Author> Get();
    }
}
