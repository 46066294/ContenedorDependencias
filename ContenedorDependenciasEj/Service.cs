﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContenedorDependenciasEj
{
    public class Service:IService
    {
        readonly IRepository _repository;
        public Service(IRepository repository) 
        {
            if (null == repository)
            {
                throw new ArgumentNullException("repository");
            }
            _repository = repository;
        }

        public void Add()
        {
            _repository.Add();
        }
    }
}
