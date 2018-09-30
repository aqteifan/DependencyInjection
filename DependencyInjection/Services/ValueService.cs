using DependencyInjection.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DependencyInjection.Services
{
    public class ValueService : IValueService
    {
        private IValueRepository _valueRepository;

        public ValueService(IValueRepository valueRepository)
        {
            _valueRepository = valueRepository;
        }
    }
}