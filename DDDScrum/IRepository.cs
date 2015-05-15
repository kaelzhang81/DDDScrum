﻿using System;
using System.Collections.Generic;

namespace DDDScrum
{
    public interface IRepository<T> where T: IAggregateRoot
    {
        List<T> FindByProductId(Guid productId);
        void Save(T backLogItem);
    }
}