﻿using System;
using Core.Database.Interfaces;
using Entities.Models;

namespace DataAccess.Abstract
{
    public interface IUserAnswersDao : ICrudBase<UserAnswers>
    {
    }
}

